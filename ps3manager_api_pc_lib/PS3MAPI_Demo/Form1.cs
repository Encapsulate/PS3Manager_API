using PS3ManagerAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PS3Lib_Mod_Demo
{
    public partial class Form1 : Form
    {
        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public Form1()
        {
            InitializeComponent();
        }
        //FORM
        private void FormUpdate()
        {
            if (PS3M_API.IsConnected)
            {
                tabC_Global.Enabled = true;
                btnDisconnect.Enabled = true;
                btnConnect.Enabled = false;
                txtB_Ip.Enabled = false;
                txtB_Port.Enabled = false;
                if (PS3M_API.IsAttached)
                {
                    tabC_Process.Enabled = true;
                    tabP_Modules.Enabled = true;
                    btnUnattach.Enabled = true;
                    comboB_Procs.Enabled = false;
                    btnRefresh.Enabled = false;
                    btnAttach.Enabled = false;
                }
                else
                {
                    tabC_Process.Enabled = false;
                    tabP_Modules.Enabled = false;
                    btnUnattach.Enabled = false;
                    comboB_Procs.Enabled = true;
                    btnRefresh.Enabled = true;
                    btnAttach.Enabled = true;
                    lV_Modules.Items.Clear();
                }
            }
            else
            {
                tabC_Global.Enabled = false;
                btnDisconnect.Enabled = false;
                btnConnect.Enabled = true;
                txtB_Ip.Enabled = true;
                txtB_Port.Enabled = true;
                comboB_Procs.Items.Clear();
            }
        }
        private void FormSyscallUpdate()
        {
            if (PS3M_API.IsConnected)
            {
                if (PS3M_API.PS3.CheckSyscall(6))
                {
                    cb_Syscall_6.Enabled = true;
                    cb_Syscall_6.Checked = false;
                }
                else
                {
                    cb_Syscall_6.Enabled = false;
                    cb_Syscall_6.Checked = true;
                }
                if (PS3M_API.PS3.CheckSyscall(7))
                {
                    cb_Syscall_7.Enabled = true;
                    cb_Syscall_7.Checked = false;
                }
                else
                {
                    cb_Syscall_7.Enabled = false;
                    cb_Syscall_7.Checked = true;
                }
                if (PS3M_API.PS3.CheckSyscall(9))
                {
                    cb_Syscall_9.Enabled = true;
                    cb_Syscall_9.Checked = false;
                }
                else
                {
                    cb_Syscall_9.Enabled = false;
                    cb_Syscall_9.Checked = true;
                }
                if (PS3M_API.PS3.CheckSyscall(10))
                {
                    cb_Syscall_10.Enabled = true;
                    cb_Syscall_10.Checked = false;
                }
                else
                {
                    cb_Syscall_10.Enabled = false;
                    cb_Syscall_10.Checked = true;
                }

                if (PS3M_API.PS3.CheckSyscall(11))
                {
                    cb_Syscall_11.Enabled = true;
                    cb_Syscall_11.Checked = false;
                }
                else
                {
                    cb_Syscall_11.Enabled = false;
                    cb_Syscall_11.Checked = true;
                }
                if (PS3M_API.PS3.CheckSyscall(35))
                {
                    cb_Syscall_35.Enabled = true;
                    cb_Syscall_35.Checked = false;
                }
                else
                {
                    cb_Syscall_35.Enabled = false;
                    cb_Syscall_35.Checked = true;
                }
                if (PS3M_API.PS3.CheckSyscall(36))
                {
                    cb_Syscall_36.Enabled = true;
                    cb_Syscall_36.Checked = false;
                }
                else
                {
                    cb_Syscall_36.Enabled = false;
                    cb_Syscall_36.Checked = true;
                }
                if (PS3M_API.PS3.CheckSyscall(8))
                {
                    cb_Syscall_8.Enabled = true;
                    if (PS3M_API.PS3.PartialCheckSyscall8() == PS3MAPI.PS3_CMD.Syscall8Mode.Enabled)
                    {
                        cb_Syscall_8.Checked = false;
                        cb_Syscall_8_P1.Checked = false;
                        cb_Syscall_8_P2.Checked = false;
                        cb_Syscall_8_P3.Checked = false;
                        cb_Syscall_8_D.Checked = false;
                    }
                    else if (PS3M_API.PS3.PartialCheckSyscall8() == PS3MAPI.PS3_CMD.Syscall8Mode.Only_PS3MAPI_Enabled)
                    {
                        cb_Syscall_8.Checked = true;
                        cb_Syscall_8_P1.Checked = true;
                        cb_Syscall_8_P2.Checked = false;
                        cb_Syscall_8_P3.Checked = false;
                        cb_Syscall_8_D.Checked = false;
                    }
                    else if (PS3M_API.PS3.PartialCheckSyscall8()  == PS3MAPI.PS3_CMD.Syscall8Mode.Only_CobraMambaAndPS3MAPI_Enabled)
                    {
                        cb_Syscall_8.Checked = true;
                        cb_Syscall_8_P1.Checked = false;
                        cb_Syscall_8_P2.Checked = true;
                        cb_Syscall_8_P3.Checked = false;
                        cb_Syscall_8_D.Checked = false;
                    }
                    else if (PS3M_API.PS3.PartialCheckSyscall8() == PS3MAPI.PS3_CMD.Syscall8Mode.FakeDisabled)
                    {
                        cb_Syscall_8.Checked = true;
                        cb_Syscall_8_P1.Checked = false;
                        cb_Syscall_8_P2.Checked = false;
                        cb_Syscall_8_P3.Checked = true;
                        cb_Syscall_8_D.Checked = false;
                    }
                }
                else
                {
                    cb_Syscall_8.Enabled = false;
                    cb_Syscall_8.Checked = true;
                    cb_Syscall_8_D.Enabled = false;
                    cb_Syscall_8_D.Checked = true;
                    cb_RemoveHook.Enabled = false;
                    cb_Syscall_8_P1.Enabled = false;
                    cb_Syscall_8_P1.Checked = false;
                    cb_Syscall_8_P2.Enabled = false;
                    cb_Syscall_8_P2.Checked = false;
                    cb_Syscall_8_P3.Enabled = false;
                    cb_Syscall_8_P3.Checked = false;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cB_PS3_Power.SelectedIndex = 0;
            cB_PS3_Buzzer.SelectedIndex = 0;
            cB_PS3_Led_Mode.SelectedIndex = 1;
            cB_PS3_Led_Color.SelectedIndex = 1;
            lbl_Lib_Version.Text = "Lib v" + PS3M_API.GetLibVersion_Str();
            FormUpdate();
            FormSyscallUpdate();
        }
        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            try
            {
                PS3M_API.DisconnectTarget();
            }
            catch
            {
            }
        }
        //CheckBox Syscall
        private void cb_Syscall_8_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Syscall_8.Checked)
            {
                cb_Syscall_8_P1.Enabled = true;
                cb_Syscall_8_P2.Enabled = true;
                cb_Syscall_8_P3.Enabled = true;
                cb_Syscall_8_D.Enabled = true;
                if (!cb_Syscall_8_P1.Checked && !cb_Syscall_8_P2.Checked && !cb_Syscall_8_P3.Checked && !cb_Syscall_8_D.Checked) cb_Syscall_8_P1.Checked = true;
            }
            else
            {
                cb_Syscall_8_P1.Enabled = false;
                cb_Syscall_8_P2.Enabled = false;
                cb_Syscall_8_P3.Enabled = false;
                cb_Syscall_8_D.Enabled = false;
                cb_Syscall_8_P1.Checked = false;
                cb_Syscall_8_P2.Checked = false;
                cb_Syscall_8_P3.Checked = false;
                cb_Syscall_8_D.Checked = false;
                cb_RemoveHook.Enabled = false;
                cb_RemoveHook.Checked = false;
            }

        }
        private void cb_Syscall_8_P1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Syscall_8_P1.Checked)
            {
                cb_Syscall_8_P3.Checked = false;
                cb_Syscall_8_P2.Checked = false;
                cb_Syscall_8_D.Checked = false;
                cb_Syscall_8.Checked = true;
            }
            else if (!cb_Syscall_8_P1.Checked && !cb_Syscall_8_P2.Checked && !cb_Syscall_8_P3.Checked && !cb_Syscall_8_D.Checked) cb_Syscall_8.Checked = false;

        }
        private void cb_Syscall_8_P2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Syscall_8_P2.Checked)
            {
                cb_Syscall_8_P1.Checked = false;
                cb_Syscall_8_P3.Checked = false;
                cb_Syscall_8_D.Checked = false;
                cb_Syscall_8.Checked = true;
            }
            else if (!cb_Syscall_8_P1.Checked && !cb_Syscall_8_P2.Checked && !cb_Syscall_8_P3.Checked && !cb_Syscall_8_D.Checked) cb_Syscall_8.Checked = false;

        }
        private void cb_Syscall_8_P3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Syscall_8_P3.Checked)
            {
                cb_Syscall_8_P1.Checked = false;
                cb_Syscall_8_P2.Checked = false;
                cb_Syscall_8_D.Checked = false;
                cb_Syscall_8.Checked = true;
            }
            else if (!cb_Syscall_8_P1.Checked && !cb_Syscall_8_P2.Checked && !cb_Syscall_8_P3.Checked && !cb_Syscall_8_D.Checked) cb_Syscall_8.Checked = false;
        }
        private void cb_Syscall_8_D_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Syscall_8_D.Checked)
            {
                cb_RemoveHook.Enabled = true;
                cb_Syscall_8_P1.Checked = false;
                cb_Syscall_8_P2.Checked = false;
                cb_Syscall_8_P3.Checked = false;
                cb_Syscall_8.Checked = true;
            }
            else
            {
                cb_RemoveHook.Enabled = false;
                cb_RemoveHook.Checked = false;
                if (!cb_Syscall_8_P1.Checked && !cb_Syscall_8_P2.Checked && !cb_Syscall_8_P3.Checked && !cb_Syscall_8_D.Checked) cb_Syscall_8.Checked = false;
            }
        }
        //LOG
        private void btn_ShowLog_Click(object sender, EventArgs e)
        {
            PS3M_API.ShowLog();
        }
        //CONNECT-DISCONNECT
        private void btnConnect_Click(object sender, EventArgs e)
        {
            p_Connection.Enabled = false;
            try
            {
                if (!PS3M_API.ConnectTarget(txtB_Ip.Text,Convert.ToInt32(txtB_Port.Text)))
                {
                    MessageBox.Show("Impossible to connect :(", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lbl_fw.Text = "Firmware: " + PS3M_API.PS3.GetFirmwareVersion_Str() + " " + PS3M_API.PS3.GetFirmwareType();
                    lbl_core_version.Text = "PS3M_API: Server v" + PS3M_API.Server.GetVersion_Str() + "|Core v" + PS3M_API.Core.GetVersion_Str();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormUpdate();
            FormSyscallUpdate();
            btnRefresh_Click(sender, e);
            btn_Temp_Refresh_Click(sender, e);
            p_Connection.Enabled = true;  
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                PS3M_API.DisconnectTarget();
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormUpdate();
        }
        //PROCESS
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tabP_Processes.Enabled = false;
            try
            {
                comboB_Procs.Items.Clear();
                foreach (uint pid in PS3M_API.Process.GetPidProcesses())
                {
                    if (pid != 0) comboB_Procs.Items.Add(PS3M_API.Process.GetName(pid));
                    else break;
                }
                comboB_Procs.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tabP_Processes.Enabled = true;   
        }
        private void btnAttach_Click(object sender, EventArgs e)
        {
            tabP_Processes.Enabled = false;
            try
            {
                if (!PS3M_API.AttachProcess(PS3M_API.Process.Processes_Pid[comboB_Procs.SelectedIndex]))
                {
                    MessageBox.Show("Impossible to attach :(", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        PS3M_API.DisconnectTarget();
                    }
                    catch
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormUpdate();
            btn_Module_Refresh_Click(sender, e);
            tabP_Processes.Enabled = true;      
        }
        private void btnUnattach_Click(object sender, EventArgs e)
        {
            tabP_Processes.Enabled = false;
            try
            {
                PS3M_API.AttachProcess(0);
            }
            catch// (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormUpdate();
            tabP_Processes.Enabled = true;
        }
       //MEMORY
        private void btnGetMem_Click(object sender, EventArgs e)
        {
            tabP_GetMem.Enabled = false;
            try
            {
                byte[] buffer = new byte[int.Parse(nUD_GetLength.Value.ToString())];
                uint offset = Convert.ToUInt32(txtB_GetOffset.Text, 16);
                PS3M_API.Process.Memory.Get(PS3M_API.Process.Process_Pid, offset, buffer);
                textOutput.Text = ByteArrayToString(buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tabP_GetMem.Enabled = true;
        }       
        private void btnSetMem_Click(object sender, EventArgs e)
        {
            tabP_SetMem.Enabled = false;
            try
            {
                byte[] buffer = new byte[textValue.Text.Length / 2];
                buffer = StringToByteArray(textValue.Text);
                uint offset = Convert.ToUInt32(txtB_SetOffset.Text, 16);
                PS3M_API.Process.Memory.Set(PS3M_API.Process.Process_Pid, offset, buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tabP_SetMem.Enabled = true;
        }
        //PS3
        private void btn_Temp_Refresh_Click(object sender, EventArgs e)
        {
            btn_Temp_Refresh.Enabled = false;
            try
            {
                uint cpu;
                uint rsx;
                PS3M_API.PS3.GetTemperature( out cpu,  out rsx);
                lbl_Temp_CPU.Text = "CPU: " + cpu.ToString() + "°C / " + (((9.0 / 5.0) * cpu) + 32).ToString() + "°F";
                lbl_Temp_RSX.Text = "RSX: " + rsx.ToString() + "°C / " + (((9.0 / 5.0) * rsx) + 32).ToString() + "°F";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btn_Temp_Refresh.Enabled = true;     
        }
        private void btn_Power_Execute_Click(object sender, EventArgs e)
        {
            p_PS3_Power.Enabled = false;
            try
            {
                if (cB_PS3_Power.SelectedIndex == 0) PS3M_API.PS3.Power(PS3MAPI.PS3_CMD.PowerFlags.ShutDown);
                else if (cB_PS3_Power.SelectedIndex == 1) PS3M_API.PS3.Power(PS3MAPI.PS3_CMD.PowerFlags.QuickReboot);
                else if (cB_PS3_Power.SelectedIndex == 2) PS3M_API.PS3.Power(PS3MAPI.PS3_CMD.PowerFlags.SoftReboot);
                else if (cB_PS3_Power.SelectedIndex == 3) PS3M_API.PS3.Power(PS3MAPI.PS3_CMD.PowerFlags.HardReboot);
                btnDisconnect_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormUpdate();
            p_PS3_Power.Enabled = true;     
        }
        private void btn_Ring_Buzzer_Click(object sender, EventArgs e)
        {
            p_PS3_Buzzer.Enabled = false;
            try
            {
                if (cB_PS3_Buzzer.SelectedIndex == 0) PS3M_API.PS3.RingBuzzer(PS3MAPI.PS3_CMD.BuzzerMode.Single);
                else if (cB_PS3_Buzzer.SelectedIndex == 1) PS3M_API.PS3.RingBuzzer(PS3MAPI.PS3_CMD.BuzzerMode.Double);
                else if (cB_PS3_Buzzer.SelectedIndex == 2) PS3M_API.PS3.RingBuzzer(PS3MAPI.PS3_CMD.BuzzerMode.Triple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            p_PS3_Buzzer.Enabled = true;     
        }
        private void btn_PS3_Led_Set_Click(object sender, EventArgs e)
        {
            p_PS3_Led.Enabled = false;
            try
            {

                if (cB_PS3_Led_Color.SelectedIndex == 0)
                {
                    if (cB_PS3_Led_Mode.SelectedIndex == 0) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Red, PS3MAPI.PS3_CMD.LedMode.Off);
                    else if (cB_PS3_Led_Mode.SelectedIndex == 1) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Red, PS3MAPI.PS3_CMD.LedMode.On);
                    else if (cB_PS3_Led_Mode.SelectedIndex == 2) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Red, PS3MAPI.PS3_CMD.LedMode.BlinkFast);
                    else if (cB_PS3_Led_Mode.SelectedIndex == 3) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Red, PS3MAPI.PS3_CMD.LedMode.BlinkSlow);
                }
                else if (cB_PS3_Led_Color.SelectedIndex == 1)
                {
                    if (cB_PS3_Led_Mode.SelectedIndex == 0) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Green, PS3MAPI.PS3_CMD.LedMode.Off);
                    else if (cB_PS3_Led_Mode.SelectedIndex == 1) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Green, PS3MAPI.PS3_CMD.LedMode.On);
                    else if (cB_PS3_Led_Mode.SelectedIndex == 2) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Green, PS3MAPI.PS3_CMD.LedMode.BlinkFast);
                    else if (cB_PS3_Led_Mode.SelectedIndex == 3) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Green, PS3MAPI.PS3_CMD.LedMode.BlinkSlow);
                }
                else if (cB_PS3_Led_Color.SelectedIndex == 2)
                {
                    if (cB_PS3_Led_Mode.SelectedIndex == 0) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Yellow, PS3MAPI.PS3_CMD.LedMode.Off);
                    else if (cB_PS3_Led_Mode.SelectedIndex == 1) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Yellow, PS3MAPI.PS3_CMD.LedMode.On);
                    else if (cB_PS3_Led_Mode.SelectedIndex == 2) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Yellow, PS3MAPI.PS3_CMD.LedMode.BlinkFast);
                    else if (cB_PS3_Led_Mode.SelectedIndex == 3) PS3M_API.PS3.Led(PS3MAPI.PS3_CMD.LedColor.Yellow, PS3MAPI.PS3_CMD.LedMode.BlinkSlow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            p_PS3_Led.Enabled = true;     
        }
        private void btn_PS3_CleanSyscall_Click(object sender, EventArgs e)
        {
            p_PS3_MimicOFW.Enabled = false;
            try
            {
                if (cb_Syscall_6.Checked) PS3M_API.PS3.DisableSyscall(6);
                if (cb_Syscall_7.Checked) PS3M_API.PS3.DisableSyscall(7);
                if (cb_Syscall_9.Checked) PS3M_API.PS3.DisableSyscall(9);
                if (cb_Syscall_10.Checked) PS3M_API.PS3.DisableSyscall(10);
                if (cb_Syscall_11.Checked) PS3M_API.PS3.DisableSyscall(11);
                if (cb_Syscall_35.Checked) PS3M_API.PS3.DisableSyscall(35);
                if (cb_Syscall_36.Checked) PS3M_API.PS3.DisableSyscall(36);
                if (cb_Syscall_8.Checked) 
                {
                    if (cb_Syscall_8_P1.Checked) PS3M_API.PS3.PartialDisableSyscall8(PS3MAPI.PS3_CMD.Syscall8Mode.Only_CobraMambaAndPS3MAPI_Enabled);
                    else if (cb_Syscall_8_P2.Checked) PS3M_API.PS3.PartialDisableSyscall8(PS3MAPI.PS3_CMD.Syscall8Mode.Only_PS3MAPI_Enabled);
                    else if (cb_Syscall_8_P3.Checked) PS3M_API.PS3.PartialDisableSyscall8(PS3MAPI.PS3_CMD.Syscall8Mode.FakeDisabled);
                    else if (cb_Syscall_8_D.Checked)
                    {
                        if (cb_RemoveHook.Checked) PS3M_API.PS3.RemoveHook();
                        PS3M_API.PS3.DisableSyscall(8);
                    }
                }
                else PS3M_API.PS3.PartialDisableSyscall8(PS3MAPI.PS3_CMD.Syscall8Mode.Enabled);
                FormUpdate();
                FormSyscallUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            p_PS3_MimicOFW.Enabled = true;    
        }
        private void btn_PS3_ClearHistory_Click(object sender, EventArgs e)
        {
            p_PS3_MimicOFW.Enabled = false;
            try
            {
                PS3M_API.PS3.ClearHistory(cB_PS3_MIMICOFW.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            p_PS3_MimicOFW.Enabled = true;   
        }   
        private void btn_PS3_Notify_Click(object sender, EventArgs e)
        {
            p_PS3_Notify.Enabled = false;
            try
            {
                PS3M_API.PS3.Notify(tB_PS3_Notify.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            p_PS3_Notify.Enabled = true;    
        }
        //MODULES
        private void btn_Module_Refresh_Click(object sender, EventArgs e)
        {
            tabP_Modules.Enabled = false;
            try
            {
                lV_Modules.Items.Clear();
                foreach (int prx_id in PS3M_API.Process.Modules.GetPrxIdModules(PS3M_API.Process.Processes_Pid[comboB_Procs.SelectedIndex]))
                {
                    if (prx_id != 0)
                    {
                        ListViewItem lvi =  new ListViewItem();
                        lvi.Text = PS3M_API.Process.Modules.GetName(PS3M_API.Process.Processes_Pid[comboB_Procs.SelectedIndex], prx_id);
                        lvi.SubItems.Add(PS3M_API.Process.Modules.GetFilename(PS3M_API.Process.Processes_Pid[comboB_Procs.SelectedIndex], prx_id));
                        lV_Modules.Items.Add(lvi);
                    }
                    else break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tabP_Modules.Enabled = true;   
        }
        private void btn_Module_Unload_Click(object sender, EventArgs e)
        {
            tabP_Modules.Enabled = false;
            try
            {
                PS3M_API.Process.Modules.Unload(PS3M_API.Process.Process_Pid, PS3M_API.Process.Modules.Modules_Prx_Id[lV_Modules.SelectedItems[0].Index]);
                btn_Module_Refresh_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tabP_Modules.Enabled = true;   
        }
        private void btn_Module_Load_Click(object sender, EventArgs e)
        {
            tabP_Modules.Enabled = false;
            try
            {
                PS3M_API.Process.Modules.Load(PS3M_API.Process.Process_Pid, tB_Module_Path.Text);
                btn_Module_Refresh_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tabP_Modules.Enabled = true;   
        }
        //WEBMAN
        private void btn_FileManager_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://" + txtB_Ip.Text);
        }
        private void btn_GameManager_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://" + txtB_Ip.Text + "/index.ps3");
        }
        private void btn_Setup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://" + txtB_Ip.Text + "/setup.ps3");
        }
        //UTILS
        private static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
        private static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }
        private void textBox_KeyPress_HexOnly(object sender, KeyPressEventArgs e)
        {
            /* less than 0 or greater than 9, and
             * less than a or greater than f, and
             * less than A or greater than F, and
             * not backspace, and
             * not delete or decimal (which is the same key as delete). */
            if (
              ((e.KeyChar < 48) || (e.KeyChar > 57)) &&
              ((e.KeyChar < 65) || (e.KeyChar > 70)) &&
              ((e.KeyChar < 97) || (e.KeyChar > 102)) &&
              (e.KeyChar != (char)Keys.Back) &&
              ((e.KeyChar != (char)Keys.Delete) || (e.KeyChar == '.'))
              ) e.Handled = true;
        }    
    }
}
