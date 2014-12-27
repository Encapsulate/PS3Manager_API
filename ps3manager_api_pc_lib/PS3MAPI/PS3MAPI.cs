
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
namespace PS3ManagerAPI
{
    public class PS3MAPI
    {

        #region PS3MAPI_CLient
        public CORE_CMD Core = new CORE_CMD();
        public PS3_CMD PS3 = new PS3_CMD();
        public PROCESS_CMD Process = new PROCESS_CMD();
        public MEMORY_CMD Memory = new MEMORY_CMD();
        public MODULES_CMD Modules = new MODULES_CMD();
        public uint[] processes_pid = new uint[16];
        public int[] modules_prx_id = new int[64];
        /// <summary>
        /// Indicates if PS3MAPI is connected
        /// </summary>
        public bool IsConnected
        {
            get { return PS3MAPI_Client_Core.IsConnected; }
        }
        /// <summary>
        /// Indicates if PS3MAPI is attached
        /// </summary>
        public bool IsAttached
        {
            get { return PS3MAPI_Client_Core.IsAttached; }
        }         
        /// <summary>Connect the target by ip and port.</summary>
        /// <param name="ip">Ip</param>
        /// <param name="port">Port (Default: 7887)</param>
        public bool ConnectTarget(string ip, int port = 7887)
        {
            try
            {
                PS3MAPI_Client_Core.Connect(ip, port);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>Connect the target with "ConnectDialog".</summary>
        public bool ConnectTarget()
        {
            ConnectDialog input = new ConnectDialog();
            try
            {
                bool result = false;
                if (input.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    result = ConnectTarget(input.txtIp.Text, int.Parse(input.txtPort.Text));
                }
                if (input != null)
                {
                    input.Dispose();
                    input = null;
                }
                return result;
            }
            catch (Exception ex)
            {
                if (input != null)
                {
                    input.Dispose();
                    input = null;
                }
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>Attach to process by pid.</summary>
        /// <param name="pid">Process PID</param>
        public bool AttachProcess(uint pid)
        {
            try
            {
                PS3MAPI_Client_Core.Process_Attach(pid);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
       /// <summary>Attach to process with "AttachDialog".</summary>
        public bool AttachProcess()
        {
            AttachDialog input = null;
            try
            {
            retry:
                bool result = false;
                if (input != null)
                {
                    input.Dispose();
                    input = null;
                }
                input = new AttachDialog(this); 
                System.Windows.Forms.DialogResult dialog_result = input.ShowDialog();
                if (dialog_result == System.Windows.Forms.DialogResult.OK)
                {
                    string[] split = input.comboBox1.Text.Split(new char[] { '_' });
                    result = AttachProcess(System.Convert.ToUInt32(split[0], 16));
                }
                else if (dialog_result == System.Windows.Forms.DialogResult.Retry)
                {
                    goto retry;
                }
                if (input != null)
                {
                    input.Dispose();
                }
                return result;
            }
            catch (Exception ex)
            {
                if (input != null)
                {
                    input.Dispose();
                    input = null;
                }
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>Disconnect the target.</summary>
        public void DisconnectTarget()
        {
            try
            {
                PS3MAPI_Client_Core.Disconnect();
            }
            catch// (Exception ex)
            {
               // throw new Exception(ex.Message, ex);
            }
        }

        public class CORE_CMD : System.Collections.CollectionBase
        {
            /// <summary>Get PS3 Manager API Core/Server Version.</summary>
            public uint GetVersion()
            {
                try
                {
                    return PS3MAPI_Client_Core.Core_Get_Version();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Get PS3 Manager API Core/Server Minimum Version.</summary>
            public uint GetMinVersion()
            {
                try
                {
                    return PS3MAPI_Client_Core.Core_GetMinVersion();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Get PS3 Firmware.</summary>
            public string GetFirmware()
            {
                try
                {
                    return PS3MAPI_Client_Core.Core_GetFirmware();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
        }

        public class PS3_CMD : System.Collections.CollectionBase
        {
            /// <summary>Shutdown PS3.</summary>
            public void Shutdown()
            {
                try
                {
                    PS3MAPI_Client_Core.PS3_Shutdown();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Reboot PS3.</summary>
            /// <param name="mode">Quick=0; Soft=1; Hard=2</param>
            public void Reboot(int mode = 0)
            {
                try
                {
                    if (mode == 0) PS3MAPI_Client_Core.PS3_Reboot();
                    else if (mode == 1) PS3MAPI_Client_Core.PS3_SoftReboot();
                    else if (mode == 2) PS3MAPI_Client_Core.PS3_HardReboot();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>PS3 VSH Notify.</summary>
            /// <param name="mode">INFO=0; CAUTION=1;  FRIEND=2;  SLIDER=3; WRONGWAY=4; DIALOG=5; DIALOGSHADOW=6; TEXT=7; POINTER=8; GRAB=9; HAND=10; PEN=11; FINGER=12; ARROW=13; ARROWRIGHT=14; PROGRESS=15; TROPHY1=16; TROPHY2=17; TROPHY3=18; TROPHY4=19;</param>
            /// <param name="msg)">Your message</param>
            public void Notify(string msg)
            {
                try
                {
                    PS3MAPI_Client_Core.PS3_Notify(msg);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Ring PS3 Buzzer.</summary>
            /// <param name="mode">Simple=0; Double=1; Continuous=2</param>
            public void RingBuzzer(int mode)
            {
                try
                {
                    PS3MAPI_Client_Core.PS3_Buzzer(mode);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>PS3 Led.</summary>
            /// <param name="color">Red=0; Green=1; Yellow=2</param>
            /// <param name="mode">Off=0; On=1; Blink Fast=2; Blink Slow=3</param>
            public void Led(int color, int mode)
            {
                try
                {
                    PS3MAPI_Client_Core.PS3_Led(color, mode);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Get PS3 Temperature.</summary>
            /// <param name="cpu">Return value for the cpu temperature in Celsius.</param>
            /// <param name="rsx">Return value for the rsx temperature in Celsius.</param>
            public void GetTemperature( out uint cpu, out uint rsx)
            {
                cpu = 0; rsx = 0;
                try
                {
                    PS3MAPI_Client_Core.PS3_GetTemp(out cpu, out rsx);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Clear Custom PS3 Syscall.</summary>
            public void CleanSyscall()
            {
                try
                {
                    PS3MAPI_Client_Core.PS3_CleanSyscall();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Clear All Custom PS3 Syscall.</summary>
            public void CleanSyscallFull()
            {
                try
                {
                    PS3MAPI_Client_Core.PS3_FullCleanSyscall();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Clear PS3 History.</summary>
            public void ClearHistory()
            {
                try
                {
                    PS3MAPI_Client_Core.PS3_ClearHistory();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            /// <summary>Check if custom PS3 syscall are removed, if they are return true.</summary>
            public bool CheckSyscall()
            {
                try
                {
                    return PS3MAPI_Client_Core.PS3_CheckSyscall();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }


        }

        public class PROCESS_CMD: System.Collections.CollectionBase
        {
              /// <summary>Get a pid list of all runing processes.</summary>
            public uint[] GetPidProcesses()
            {
                try
                {
                    return PS3MAPI_Client_Core.Process_GetPidList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Get name of this process.</summary>
            /// <param name="pid">Process Pid</param>
            public string GetName(uint pid)
                {
                    try
                    {
                        return PS3MAPI_Client_Core.Process_GetName(pid);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex);
                    }
                }
           }

        public class MEMORY_CMD : System.Collections.CollectionBase
        {
            /// <summary>Set memory to the attached process.</summary>
            /// <param name="Address">Address</param>
            /// <param name="Bytes">Bytes</param>
            public void Set(uint Address, byte[] Bytes)
            {
                try
                {
                    PS3MAPI_Client_Core.Memory_Set(Address, Bytes);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Get memory from the attached process.</summary>
            /// <param name="Address">Address</param>
            /// <param name="Bytes">Bytes</param>
            public void Get(uint Address, byte[] Bytes)
            {
                try
                {
                    PS3MAPI_Client_Core.Memory_Get(Address, Bytes);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Get memory from the attached process.</summary>
            /// <param name="Address">Address</param>
            /// <param name="Length">Length</param>
            public byte[] Get(uint Address, uint Length)
            {
                try
                {
                    byte[] buffer = new byte[Length];
                    PS3MAPI_Client_Core.Memory_Get(Address, buffer);
                    return buffer;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
        }

        public class MODULES_CMD : System.Collections.CollectionBase
        {
            /// <summary>Get a prx_id list of all modules for this process.</summary>
            /// <param name="pid">Process Pid</param>
            public int[] GetPrxIdModules(uint pid)
            {
                try
                {
                    return PS3MAPI_Client_Core.Module_GetPrxIdList(pid);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Get name of this module</summary>
            /// <param name="pid">Process Pid</param>
            /// <param name="prxid">Module Prx_id</param>
            public string GetName(uint pid, int prxid)
            {
                try
                {
                    return PS3MAPI_Client_Core.Module_GetName(pid, prxid);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Load a module.</summary>
            /// <param name="pid">Process Pid</param>
            /// <param name="path">Path of the plugin to load.</param>
            public void Load(uint pid, string path)
            {
                try
                {
                    PS3MAPI_Client_Core.Module_Load(pid, path);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            /// <summary>Unload a module.</summary>
            /// <param name="pid">Process Pid</param>
            /// <param name="prxid">Module Prx_id</param>
            public void Unload(uint pid, int prxid)
            {
                try
                {
                     PS3MAPI_Client_Core.Module_Unload(pid, prxid);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
        }

        #endregion PS3MAPI_CLient

        #region PS3MAPI_Client_Core

        internal class PS3MAPI_Client_Core
        {
            #region Private Members

            static private int ps3m_api_pc_lib_version = 0x0001;
            static private int ps3m_api_server_minversion = 0x0001;
            static private PS3MAPI_ResponseCode eResponseCode;
            static private string sResponse;
            static private string sMessages = "";
            static private string sServerIP = "";
            static private int iPort = 7887;
            static private string sBucket = "";
            static private int iTimeout = 5000;	// 5 Second
            static private uint iPid = 0;

            #endregion Private Members

            #region Internal Members
            static internal Socket main_sock;
            static internal Socket listening_sock;
            static internal Socket data_sock;
            static internal IPEndPoint main_ipEndPoint;
            static internal IPEndPoint data_ipEndPoint;

            #endregion Internal Members

            #region Public Properties
            /// <summary>
            /// Enumerated PS3MAPI Response Codes
            /// </summary>
            public enum PS3MAPI_ResponseCode
            {
                DataConnectionAlreadyOpen = 125,
                MemoryStatusOK = 150,
                CommandOK = 200,
                RequestSuccessful = 226,
                EnteringPassiveMode = 227,
                PS3MAPIConnected = 220,
                PS3MAPIConnectedOK = 230,
                MemoryActionCompleted = 250,
                MemoryActionPended = 350
            }
            /// <summary>
            /// Current PS3MAPI Response Code
            /// </summary>
            static public PS3MAPI_ResponseCode ResponseCode
            {
                get { return eResponseCode; }
                set { eResponseCode = value; }
            }
            /// <summary>
            /// Server IP Address for Connection
            /// </summary>
            static public string ServerIP
            {
                get { return sServerIP; }
                set { sServerIP = value; }
            }
            /// <summary>
            /// Response String, Contains Details of the PS3MAPI Response
            /// </summary>
            static public string ResponseString
            {
                get { return sResponse; }
                set { sResponse = value; }
            }
            /// <summary>
            /// Messages from the Server
            /// </summary>
            static public string Messages
            {
                get
                {
                    string tmp = sMessages;
                    sMessages = "";
                    return tmp;
                }
            }
            /// <summary>
            /// User Specified Timeout: Defaults to 5000 (5 seconds)
            /// </summary>
            static public int Timeout
            {
                get { return iTimeout; }
                set { iTimeout = value; }
            }
            /// <summary>
            /// User Specified Port: Defaults to 7887
            /// </summary>
            static public int Port
            {
                get { return iPort; }
                set { iPort = value; }
            }
            /// <summary>
            /// Indicates if PS3MAPI is connected
            /// </summary>
            static public bool IsConnected
            {
                get { return ((main_sock != null) ? main_sock.Connected : false); }
            }
            /// <summary>
            /// Indicates if PS3MAPI is attached
            /// </summary>
            static public bool IsAttached
            {
                get { return ((iPid != 0) ? true : false); }
            }
            #endregion Public Properties

            //SERVER---------------------------------------------------------------------------------
            internal static void Connect()
            {
                Connect(ServerIP, Port);
            }
            internal static void Connect(string sServer, int iPort)
            {
                ServerIP = sServer;
                Port = iPort;
                if (Port.ToString().Length == 0)
                {
                    throw new Exception("Unable to Connect - No Port Specified.");
                }
                if (ServerIP.Length == 0)
                {
                    throw new Exception("Unable to Connect - No Server Specified.");
                }
                if (main_sock != null)
                {
                    if (main_sock.Connected)
                    {
                        return;
                    }
                }
                main_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                main_ipEndPoint = new IPEndPoint(Dns.GetHostByName(ServerIP).AddressList[0], Port);
                try
                {
                    main_sock.Connect(main_ipEndPoint);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                ReadResponse();
                if (ResponseCode != PS3MAPI_ResponseCode.PS3MAPIConnected)
                {
                    Fail();
                }
                ReadResponse();
                if (ResponseCode != PS3MAPI_ResponseCode.PS3MAPIConnectedOK)
                {
                    Fail();
                }
                if (Server_GetMinVersion() > ps3m_api_server_minversion)
                {
                    Disconnect();
                    throw new Exception("PS3M_API_PC_LIB OUTDATED! PLEASE UPDATE.");
                }
                return;
            }
            internal static void Disconnect()
            {
                CloseDataSocket();
                if (main_sock != null)
                {
                    if (main_sock.Connected)
                    {
                        SendCommand("DISCONNECT");
                        iPid = 0;
                        main_sock.Close();
                    }
                    main_sock = null;
                }
                main_ipEndPoint = null;
            }
            internal static uint Server_Get_Version()
            {
                if (IsConnected)
                {
                    SendCommand("SERVER GETVERSION");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                    return Convert.ToUInt32(ResponseString);
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static uint Server_GetMinVersion()
            {
                if (IsConnected)
                {
                    SendCommand("SERVER GETMINVERSION");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                    return Convert.ToUInt32(ResponseString);
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            //CORE-----------------------------------------------------------------------------------
            internal static uint Core_Get_Version()
            {
                if (IsConnected)
                {
                    SendCommand("CORE GETVERSION");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                    return Convert.ToUInt32(ResponseString);
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static uint Core_GetMinVersion()
            {
                if (IsConnected)
                {
                    SendCommand("CORE GETMINVERSION");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                    return Convert.ToUInt32(ResponseString);
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static string Core_GetFirmware()
            {
                if (IsConnected)
                {
                    SendCommand("CORE GETFW");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                    return ResponseString;
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            //PS3------------------------------------------------------------------------------------
            internal static void PS3_Shutdown()
            {
                if (IsConnected)
                {
                    SendCommand("PS3 SHUTDOWN");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            Disconnect();
                            break;
                        default:
                            Fail();
                            break;
                    }

                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static void PS3_Reboot()
            {
                if (IsConnected)
                {
                    SendCommand("PS3 REBOOT");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            Disconnect();
                            break;
                        default:
                            Fail();
                            break;
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static void PS3_SoftReboot()
            {
                if (IsConnected)
                {
                    SendCommand("PS3 SOFTREBOOT");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            Disconnect();
                            break;
                        default:
                            Fail();
                            break;
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static void PS3_HardReboot()
            {
                if (IsConnected)
                {
                    SendCommand("PS3 HARDREBOOT");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            Disconnect();
                            break;
                        default:
                            Fail();
                            break;
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static void PS3_Notify(string msg)
            {
                if (IsConnected)
                {
                    SendCommand("PS3 NOTIFY  " + msg);
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static void PS3_Buzzer(int mode)
            {
                if (IsConnected)
                {
                    SendCommand("PS3 BUZZER " + mode.ToString());
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static void PS3_Led(int color, int mode)
            {
                if (IsConnected)
                {
                    SendCommand("PS3 LED " + color.ToString() + " " + mode.ToString());
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static void PS3_GetTemp(out uint cpu, out uint rsx)
            {
                cpu = 0; rsx = 0;
                if (IsConnected)
                {
                    SendCommand("PS3 GETTEMP");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
					string[] tmp = ResponseString.Split(new char[] { '|' });
                    cpu = System.Convert.ToUInt32(tmp[0], 10);
                    rsx = System.Convert.ToUInt32(tmp[1], 10);
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static void PS3_CleanSyscall()
            { 
                if (IsConnected)
                {
                    SendCommand("PS3 CLEANSYSCALL");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static void PS3_FullCleanSyscall()
            {
                if (IsConnected)
                {
                    SendCommand("PS3 FULLCLEAN");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static void PS3_ClearHistory()
            {
                if (IsConnected)
                {
                    SendCommand("PS3 DELHISTORY");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static bool PS3_CheckSyscall()
            {
                if (IsConnected)
                {
                    SendCommand("PS3 CHECKSYSCALL");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                    if (Convert.ToInt32(ResponseString) == 0) return true;
                    else return false;
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            //PROCESS--------------------------------------------------------------------------------
            internal static void Process_Attach(uint proc_id)
            {
                if (IsConnected)
                {
                    SendCommand("PROCESS ATTACH " + proc_id.ToString());
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            iPid = proc_id;
                            break;
                        default:
                            Fail();
                            break;
                    }
                }
                else
                {
                    iPid = 0;
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static string Process_GetName(uint pid)
            { 
                if (IsConnected)
                {
                    SendCommand("PROCESS GETNAME " + pid.ToString());
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                    return ResponseString;
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            internal static uint[] Process_GetPidList()
            {
                if (IsConnected)
                {
                    SendCommand("PROCESS GETALLPID");
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                    int i = 0;
                    uint[] ret_pid_list = new uint[16];
                    foreach (string s in ResponseString.Split(new char[] { '|' }))
                    {
                        if (s.Length != 0 && s != null && s != "") { ret_pid_list[i] = Convert.ToUInt32(s, 10); i++; }
                    }
                    return ret_pid_list;
                }
                else
                {
                    throw new Exception("PS3MAPI not connected!");
                }
            }
            //MEMORY--------------------------------------------------------------------------------
            internal static void Memory_Get(uint Address, byte[] Bytes)
            {
                if (IsConnected && IsAttached)
                {
                    SetBinaryMode(true);
                    int BytesLength = Bytes.Length;
                    long TotalBytes = 0;
                    long lBytesReceived = 0;
                    bool bComplete = false;
                    OpenDataSocket();
                    SendCommand("MEMORY GET " + string.Format("{0}", Address) + " " + string.Format("{0}", Bytes.Length));
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.DataConnectionAlreadyOpen:
                        case PS3MAPI_ResponseCode.MemoryStatusOK:
                            break;
                        default:
                            throw new Exception(ResponseString);
                    }
                    ConnectDataSocket();
                    while (bComplete != true)
                    {
                        try
                        {
                            lBytesReceived = data_sock.Receive(Bytes, BytesLength, 0);
                            if (lBytesReceived > 0)
                            {
                                TotalBytes += lBytesReceived;
                                if ((int)(((TotalBytes) * 100) / BytesLength) >= 100) bComplete = true;
                            }
                            else
                            {
                                bComplete = true;
                            }
                            if (bComplete)
                            {
                                CloseDataSocket();
                                ReadResponse();
                                switch (ResponseCode)
                                {
                                    case PS3MAPI_ResponseCode.RequestSuccessful:
                                    case PS3MAPI_ResponseCode.MemoryActionCompleted:
                                        break;
                                    default:
                                        throw new Exception(ResponseString);
                                }
                                SetBinaryMode(false);
                            }
                        }
                        catch (Exception e)
                        {
                            CloseDataSocket();
                            ReadResponse();
                            SetBinaryMode(false);
                            throw e;
                        }
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected or not attached!");
                }
            }
            internal static void Memory_Set(uint Address, byte[] Bytes)
            {
                if (IsConnected && IsAttached)
                {
                    SetBinaryMode(true);
                    int BytesLength = Bytes.Length;
                    long TotalBytes = 0;
                    long lBytesSended = 0;
                    bool bComplete = false;
                    OpenDataSocket();
                    SendCommand("MEMORY SET " + string.Format("{0}", Address));
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.DataConnectionAlreadyOpen:
                        case PS3MAPI_ResponseCode.MemoryStatusOK:
                            break;
                        default:
                            throw new Exception(ResponseString);
                    }
                    ConnectDataSocket();
                    while (bComplete != true)
                    {
                        try
                        {
                            lBytesSended = data_sock.Send(Bytes, BytesLength, 0);
                            bComplete = false;
                            if (lBytesSended > 0)
                            {
                                TotalBytes += lBytesSended;
                                if ((int)(((TotalBytes) * 100) / BytesLength) >= 100) bComplete = true;
                            }
                            else
                            {
                                bComplete = true;
                            }
                            if (bComplete)
                            {
                                CloseDataSocket();
                                ReadResponse();
                                switch (ResponseCode)
                                {
                                    case PS3MAPI_ResponseCode.RequestSuccessful:
                                    case PS3MAPI_ResponseCode.MemoryActionCompleted:
                                        break;
                                    default:
                                        throw new Exception(ResponseString);
                                }
                                SetBinaryMode(false);
                            }
                        }
                        catch (Exception e)
                        {
                            CloseDataSocket();
                            ReadResponse();
                            SetBinaryMode(false);
                            throw e;
                        }
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected or not attached!");
                }
            }
            //MODULES--------------------------------------------------------------------------------
            internal static int[] Module_GetPrxIdList(uint pid)
            {
                if (IsConnected && IsAttached)
                {
                    SendCommand("MODULE GETALLPRXID " + pid.ToString());
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                    int i = 0;
                    int[] ret_prxid_list = new int[64];
                    foreach (string s in ResponseString.Split(new char[] { '|' }))
                    {
                        if (s.Length != 0 && s != null && s != "") { ret_prxid_list[i] = Convert.ToInt32(s, 10); i++; }
                    }
                    return ret_prxid_list;
                }
                else
                {
                    throw new Exception("PS3MAPI not connected or not attached!");
                }
            }
            internal static string Module_GetName(uint pid, int prxid)
            {
                if (IsConnected && IsAttached)
                {
                    SendCommand("MODULE GETNAME " + pid.ToString() + " " + prxid.ToString());
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                    return ResponseString;
                }
                else
                {
                    throw new Exception("PS3MAPI not connected or not attached!");
                }
            }
            internal static void Module_Load(uint pid, string path)
            {
                if (IsConnected && IsAttached)
                {
                    SendCommand("MODULE LOAD " + pid.ToString() + " " + path);
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected or not attached!");
                }
            }
            internal static void Module_Unload(uint pid, int prx_id)
            {
                if (IsConnected && IsAttached)
                {
                    SendCommand("MODULE UNLOAD " + pid.ToString() + " " + prx_id.ToString());
                    switch (ResponseCode)
                    {
                        case PS3MAPI_ResponseCode.RequestSuccessful:
                        case PS3MAPI_ResponseCode.CommandOK:
                            break;
                        default:
                            Fail();
                            break;
                    }
                }
                else
                {
                    throw new Exception("PS3MAPI not connected or not attached!");
                }
            }
            //--------------------------------------------------------------------------------------
            internal static void Fail()
            {
                Fail(new Exception("[" + ResponseCode.ToString() + "] " + ResponseString));
            }
            internal static void Fail(Exception e)
            {
                Disconnect();
                throw e;
            }
            internal static void SetBinaryMode(bool bMode)
            {
                SendCommand("TYPE" + ((bMode) ? " I" : " A"));
                switch (ResponseCode)
                {
                    case PS3MAPI_ResponseCode.RequestSuccessful:
                    case PS3MAPI_ResponseCode.CommandOK:
                        break;
                    default:
                        Fail();
                        break;
                }
            }
            internal static void OpenDataSocket()
            {
                string[] pasv;
                string sServer;
                int iPort;
                Connect();
                SendCommand("PASV");
                if (ResponseCode != PS3MAPI_ResponseCode.EnteringPassiveMode)
                {
                     Fail();
                }
                try
                {
                     int i1, i2;
                     i1 = ResponseString.IndexOf('(') + 1;
                     i2 = ResponseString.IndexOf(')') - i1;
                     pasv = ResponseString.Substring(i1, i2).Split(',');
                 }
                 catch (Exception)
                 {
                     Fail(new Exception("Malformed PASV response: " + ResponseString));
                     throw new Exception("Malformed PASV response: " + ResponseString);
                 }

                 if (pasv.Length < 6)
                 {
                     Fail(new Exception("Malformed PASV response: " + ResponseString));
                 }

                 sServer = String.Format("{0}.{1}.{2}.{3}", pasv[0], pasv[1], pasv[2], pasv[3]);
                 iPort = (int.Parse(pasv[4]) << 8) + int.Parse(pasv[5]);
                 try
                 {
                     CloseDataSocket();
                     data_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                     data_ipEndPoint = new IPEndPoint(Dns.GetHostByName(ServerIP).AddressList[0], iPort);
                     data_sock.Connect(data_ipEndPoint);
                 }
                 catch (Exception e)
                 {
                     throw new Exception("Failed to connect for data transfer: " + e.Message);
                 }
            }
            internal static void ConnectDataSocket()
            {
                if (data_sock != null)		// already connected (always so if passive mode)
                    return;
                try
                {
                    data_sock = listening_sock.Accept();	// Accept is blocking
                    listening_sock.Close();
                    listening_sock = null;
                    if (data_sock == null)
                    {
                        throw new Exception("Winsock error: " +
                            Convert.ToString(System.Runtime.InteropServices.Marshal.GetLastWin32Error()));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to connect for data transfer: " + ex.Message);
                }
            }
            internal static void CloseDataSocket()
            {
                if (data_sock != null)
                {
                    if (data_sock.Connected)
                    {
                        data_sock.Close();
                    }
                    data_sock = null;
                }
                data_ipEndPoint = null;
            }
            internal static void ReadResponse()
            {
                string sBuffer;
                sMessages = "";

                while (true)
                {
                    sBuffer = GetLineFromBucket();
                    if (Regex.Match(sBuffer, "^[0-9]+ ").Success)
                    {
                        ResponseString = sBuffer.Substring(4).Replace("\r", "").Replace("\n", "");
                        ResponseCode = (PS3MAPI_ResponseCode)int.Parse(sBuffer.Substring(0, 3));
                        break;
                    }
                    else
                    {
                        sMessages += Regex.Replace(sBuffer, "^[0-9]+-", "") + "\n";
                    }
                }
            }
            internal static void SendCommand(string sCommand)
            {
                Connect();
                Byte[] byCommand = Encoding.ASCII.GetBytes((sCommand + "\r\n").ToCharArray());
                main_sock.Send(byCommand, byCommand.Length, 0);
                ReadResponse();
            }
            internal static void FillBucket()
            {
                Byte[] bytes = new Byte[512];
                long lBytesRecieved;
                int iMilliSecondsPassed = 0;
                while (main_sock.Available < 1)
                {
                    System.Threading.Thread.Sleep(50);
                    iMilliSecondsPassed += 50;

                    if (iMilliSecondsPassed > Timeout) // Prevents infinite loop
                    {
                        Fail(new Exception("Timed out waiting on server to respond."));
                    }
                }
                while (main_sock.Available > 0)
                {
                    // gives any further data not yet received, a small chance to arrive
                    lBytesRecieved = main_sock.Receive(bytes, 512, 0);
                    sBucket += Encoding.ASCII.GetString(bytes, 0, (int)lBytesRecieved);
                    System.Threading.Thread.Sleep(50);
                }
            }
            internal static string GetLineFromBucket()
            {
                string sBuffer = "";
                int i = sBucket.IndexOf('\n');

                while (i < 0)
                {
                    FillBucket();
                    i = sBucket.IndexOf('\n');
                }

                sBuffer = sBucket.Substring(0, i);
                sBucket = sBucket.Substring(i + 1);

                return sBuffer;
            }

        }

        #endregion PS3MAPI_Client_Core

    }
}
