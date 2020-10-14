using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SuspendProcess
{
    public partial class frmMain : Form
    {
        public int LoopProcessId;

        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);

        private static void SuspendProcess(int pid)
        {
            var process = Process.GetProcessById(pid); // throws exception if process does not exist

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                SuspendThread(pOpenThread);

                CloseHandle(pOpenThread);
            }
        }

        public static void ResumeProcess(int pid)
        {
            var process = Process.GetProcessById(pid);

            if (process.ProcessName == string.Empty)
                return;

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                var suspendCount = 0;
                do
                {
                    suspendCount = ResumeThread(pOpenThread);
                } while (suspendCount > 0);

                CloseHandle(pOpenThread);
            }
        }

        public void GetProcessList()
        {
            Process[] processlist = Process.GetProcesses();

            foreach(Process p in processlist)
            {
                lbProcessList.Items.Add(p.ProcessName + ' ' + p.Id);
            }
        }

        public int GetProcessIdByName(string ProcessName)
        {
            var process = Process.GetProcessesByName(ProcessName)
                ?.FirstOrDefault(x => x.ProcessName == ProcessName);

            if (process == null)
            {
                return -1;
            }

            return process.Id;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            GetProcessList();
        }

        private void lbProcessList_Click(object sender, EventArgs e)
        {
            string ProcessName = lbProcessList.Items[lbProcessList.SelectedIndex].ToString().Split(' ')[0];

            txtProcessName.Text = ProcessName;
        }

        private void BtnSuspendProcess_Click(object sender, EventArgs e)
        {
            if (txtProcessName.Text == String.Empty)
                return;

            //Suspend Process
            if(BtnSuspendProcess.Text == "Suspend Process")
            {
                int pid = GetProcessIdByName(txtProcessName.Text);

                if (pid == -1)
                {
                    MessageBox.Show("not found process","error");
                    return;
                }

                SuspendProcess(pid);
                txtProcessName.Enabled = false;
                BtnSuspendProcess.Text = "Resume Process";
            }
            else // Resume Process
            {
                int pid = GetProcessIdByName(txtProcessName.Text);

                if (pid == -1)
                {
                    MessageBox.Show("not found process", "error");
                    return;
                }

                ResumeProcess(pid);
                txtProcessName.Enabled = true;
                BtnSuspendProcess.Text = "Suspend Process";
            }
        }

        private void BtnRefreshList_Click(object sender, EventArgs e)
        {
            lbProcessList.Items.Clear();
            GetProcessList();
        }

        private void cbLoop_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoop.Checked)
            {
                txtLoopProcessName.Enabled = false;

                TmrLoopProcessSuspend.Interval = Int32.Parse(txtLoopInterval.Text);
                TmrLoopProcessSuspend.Enabled = true;
            }
            else
            {
                ResumeProcess(LoopProcessId);

                txtLoopProcessName.Enabled = true;
                TmrLoopProcessSuspend.Enabled = false;
            }
        }

        private void txtLoopDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txtLoopInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        async private void TmrLoopProcessSuspend_Tick(object sender, EventArgs e)
        {
            LoopProcessId = GetProcessIdByName(txtLoopProcessName.Text);

            if (LoopProcessId == -1)
                return;

            await Task.Delay(Int32.Parse(txtLoopDelay.Text));

            SuspendProcess(LoopProcessId);
            TmrLoopProcessSuspend.Enabled = false;
        }
    }
}
