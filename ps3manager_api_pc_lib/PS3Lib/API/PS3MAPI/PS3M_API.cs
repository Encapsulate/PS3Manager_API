// ************************************************* //
//                 PS3MAPI By _NzV_                  //
//                                                   //
// ************************************************* //

using System;
using System.Linq;
using System.Windows.Forms;

namespace PS3Lib
{
    public class PS3MAPI
    {
        private static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();

        public PS3MAPI()
        {
            PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        }

        public Extension Extension
        {
            get { return new Extension(SelectAPI.PS3Manager); }
        }

        /// <summary>Connect your console (with connect dialog).</summary>
        public bool ConnectTarget()
        {
            return PS3M_API.ConnectTarget();
        }

        /// <summary>Connect your console by ip address.</summary>
        public bool ConnectTarget(string targetIP)
        {
            return PS3M_API.ConnectTarget(targetIP);
        }

        /// <summary>Connect your console by ip address and port.</summary>
        public bool ConnectTarget(string targetIP, int port)
        {
            return PS3M_API.ConnectTarget(targetIP, port);
        }

        /// <summary>Get the connection status of the console.</summary>
        public bool IsConnected()
        {
            return PS3M_API.IsConnected;
        }

        /// <summary>Disconnect your console.</summary>
        public bool DisconnectTarget()
        {
            try { PS3M_API.DisconnectTarget(); }
            catch { }
            return true;
        }

        /// <summary>Attach to process (with attach dialog).</summary>
        public bool AttachProcess()
        {
            return PS3M_API.AttachProcess();
        }

        /// <summary>Attach to desired process pid.</summary>
        public bool AttachProcess(uint pid)
        {
            return PS3M_API.AttachProcess(pid);
        }

        /// <summary>Get a pid list of all processes available.</summary>
        public bool GetProcessList(out uint[] pids)
        {
            pids = new uint[16];
            try
            {
                pids = PS3M_API.Process.GetPidProcesses();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Get the process name of your choice.</summary>
        public bool GetProcessName(uint pid, out string name)
        {
            name = "";
            try
            {
                name = PS3M_API.Process.GetName(pid);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Return the current process attached.</summary>
        public uint GetAttachedProcess()
        {
            return PS3M_API.Process.Process_Pid;
        }

        /// <summary>Set memory to offset (uint).</summary>
        public bool SetMemory(uint offset, byte[] buffer)
        {
            try
            {
                PS3M_API.Process.Memory.Set(PS3M_API.Process.Process_Pid, offset, buffer);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Set memory to offset (ulong).</summary>
        public bool SetMemory(ulong offset, byte[] buffer)
        {
            try
            {
                PS3M_API.Process.Memory.Set(PS3M_API.Process.Process_Pid, (uint)offset, buffer);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Set memory to offset (string hex).</summary>
        public bool SetMemory(ulong offset, string hexadecimal, EndianType Type = EndianType.BigEndian)
        {
            byte[] Entry = StringToByteArray(hexadecimal);
            if (Type == EndianType.LittleEndian)
                Array.Reverse(Entry);
            try
            {
                PS3M_API.Process.Memory.Set(PS3M_API.Process.Process_Pid, (uint)offset, Entry);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Get memory from offset (uint).</summary>
        public bool GetMemory(uint offset, byte[] buffer)
        {
            try
            {
                PS3M_API.Process.Memory.Get(PS3M_API.Process.Process_Pid, offset, buffer);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Get memory from offset (ulong).</summary>
        public bool GetMemory(ulong offset, byte[] buffer)
        {
            try
            {
                PS3M_API.Process.Memory.Get(PS3M_API.Process.Process_Pid, (uint)offset, buffer);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Like Get memory but this function return directly the buffer from the offset (uint).</summary>
        public byte[] GetBytes(uint offset, uint length)
        {
            byte[] buffer = new byte[length];
            PS3M_API.Process.Memory.Get(PS3M_API.Process.Process_Pid, offset, buffer);
            return buffer;
        }

        /// <summary>Like Get memory but this function return directly the buffer from the offset (ulong).</summary>
        public byte[] GetBytes(ulong offset, uint length)
        {
            byte[] buffer = new byte[length];
            PS3M_API.Process.Memory.Get(PS3M_API.Process.Process_Pid, (uint)offset, buffer);
            return buffer;
        }

        /// <summary>Display the notify message on your PS3.</summary>
        public bool Notify(string message)
        {
            try
            {
                PS3M_API.PS3.Notify(message);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>You can shutdown the console or just reboot her according the flag selected.</summary>
        public bool Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags flag)
        {
             try
             {
                PS3M_API.PS3.Power(flag);
                return true;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
             }
        }

        /// <summary>Your console will emit a song.</summary>
        public bool RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode mode)
        {
             try
             {
                PS3M_API.PS3.RingBuzzer(mode);
                return true;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
             }
        }

        /// <summary>Change leds for your console.</summary>
        public bool SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor color, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode mode)
        {
             try
             {
                PS3M_API.PS3.Led(color, mode);
                return true;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
             }
        }

        /// <summary>Return the current firmware of your console in string format.</summary>
        public string GetFirmwareVersion()
        {
            return PS3M_API.PS3.GetFirmwareVersion_Str();
        }
        
        /// <summary>Return the type of your firmware in string format.</summary>
        public string GetFirmwareType()
        {
            return PS3M_API.PS3.GetFirmwareType();
        }

        /// <summary>Return the current temperature of your system in string.</summary>
        public string GetTemperatureCELL()
        {
            try
            {
                uint cpu;
                uint rsx;
                PS3M_API.PS3.GetTemperature(out cpu, out rsx);
                return cpu.ToString() + "°C / " + (((9.0 / 5.0) * cpu) + 32).ToString() + "°F";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ERROR";
            }
        }

        /// <summary>Return the current temperature of your system in string.</summary>
        public string GetTemperatureRSX()
        {
            try
            {
                uint cpu;
                uint rsx;
                PS3M_API.PS3.GetTemperature(out cpu, out rsx);
                return rsx.ToString() + "°C / " + (((9.0 / 5.0) * rsx) + 32).ToString() + "°F";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ERROR";
            }

        }

        /// <summary>Get the current temperature of your system (°C).</summary>
        public bool GetTemperatureCelcius(out uint cpu, out uint rsx)
        {
            cpu = 0; rsx = 0;
            try
            {
                 PS3M_API.PS3.GetTemperature(out cpu, out rsx);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        /// <summary>Get the current temperature of your system (°F).</summary>
        public bool GetTemperatureFahrenheit(out uint cpu, out uint rsx)
        {
            cpu = 0; rsx = 0;
            try
            {
                PS3M_API.PS3.GetTemperature(out cpu, out rsx);
                cpu = Convert.ToUInt32(((9.0 / 5.0) * cpu) + 32);
                rsx = Convert.ToUInt32(((9.0 / 5.0) * rsx) + 32);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        /// <summary>Return PS3M_API Lib version in string format.</summary>
        public string GetLibVersion()
        {
            return PS3M_API.GetLibVersion_Str();
        }

        /// <summary>Return PS3M_API Server version in string format.</summary>
        public string GetServerVersion()
        {
            return PS3M_API.Server.GetVersion_Str();
        }

        /// <summary>Return PS3M_API Core version in string format.</summary>
        public string GetCoreVersion()
        {
            return PS3M_API.Core.GetVersion_Str();
        }

        /// <summary>Return true if this syscall is enbaled.</summary>
        public bool Syscall_IsEnabled(int num)
        {
            try
            {
                PS3M_API.PS3.CheckSyscall(num);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Disable this syscall.</summary>
        public bool Syscall_Disable(int num)
        {
            try
            {
                PS3M_API.PS3.DisableSyscall(num);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Return current mode of syscall 8.</summary>
        public PS3ManagerAPI.PS3MAPI.PS3_CMD.Syscall8Mode Syscall8_CurrentMode()
        {
            try
            {
                PS3M_API.PS3.PartialCheckSyscall8();
                return PS3M_API.PS3.PartialCheckSyscall8();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return PS3ManagerAPI.PS3MAPI.PS3_CMD.Syscall8Mode.Disabled;
            }
        }

        /// <summary>Set current mode of syscall 8.</summary>
        public bool Syscall8_SetMode(PS3ManagerAPI.PS3MAPI.PS3_CMD.Syscall8Mode mode)
        {
            try
            {
                PS3M_API.PS3.PartialDisableSyscall8(mode);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error PS3M_API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal static byte[] StringToByteArray(string hex)
        {
            string replace = hex.Replace("0x", "");
            string Stringz = replace.Insert(replace.Length - 1, "0");

            int Odd = replace.Length;
            bool Nombre;
            if (Odd % 2 == 0)
                Nombre = true;
            else
                Nombre = false;
            try
            {
                if (Nombre == true)
                {
                    return Enumerable.Range(0, replace.Length)
                 .Where(x => x % 2 == 0)
                 .Select(x => Convert.ToByte(replace.Substring(x, 2), 16))
                 .ToArray();
                }
                else
                {
                    return Enumerable.Range(0, replace.Length)
                 .Where(x => x % 2 == 0)
                 .Select(x => Convert.ToByte(Stringz.Substring(x, 2), 16))
                 .ToArray();
                }
            }
            catch { throw new ArgumentException("Value not possible.", "Byte Array"); }
        }

    }
}
