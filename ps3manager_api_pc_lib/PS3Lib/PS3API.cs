// ************************************************* //
// Features v4.5 [U] By _NzV_ :                      //
// - Add Support for PS3MAPI By _NzV_                //
//                                                   //
// ************************************************* //

// ************************************************* //
//    --- Copyright (c) 2014 iMCS Productions ---    //
// ************************************************* //
//              PS3Lib v4 By FM|T iMCSx              //
//                                                   //
// Features v4.4 :                                   //
// - Support CCAPI v2.6 C# by iMCSx                  //
// - Set Boot Console ID                             //
// - Popup better form with icon                     //
// - CCAPI Consoles List Popup French/English        //
// - CCAPI Get Console Info                          //
// - CCAPI Get Console List                          //
// - CCAPI Get Number Of Consoles                    //
// - Get Console Name TMAPI/CCAPI                    //
//                                                   //
// Credits : FM|T Enstone , Buc-ShoTz                //
//                                                   //
// Follow me :                                       //
//                                                   //
// FrenchModdingTeam.com                             //
// Youtube.com/iMCSx                                 //
// Twitter.com/iMCSx                                 //
// Facebook.com/iMCSx                                //
//                                                   //
// ************************************************* //

using PS3Lib.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS3Lib
{

    public enum SelectAPI
    {
        ControlConsole,
        TargetManager,
        PS3Manager
    }

    public class PS3API
    {
        private static string targetName = String.Empty;
        private static string targetIp = String.Empty;

        public PS3API(SelectAPI API = SelectAPI.TargetManager)
        {
            SetAPI.API = API;
            MakeInstanceAPI(API);
        }

        public void setTargetName(string value)
        {
            targetName = value;
        }

        private void MakeInstanceAPI(SelectAPI API)
        {
            if (API == SelectAPI.TargetManager)
            {
                if (Common.TmApi == null)
                    Common.TmApi = new TMAPI();
            }
            else if (API == SelectAPI.ControlConsole)
            {
                if (Common.CcApi == null)
                    Common.CcApi = new CCAPI();
            }
            else if (API == SelectAPI.PS3Manager)
            {
                if (Common.Ps3mApi == null)
                    Common.Ps3mApi = new PS3MAPI();
            }
        }

        private class SetAPI
        {
            public static SelectAPI API;
        }

        private class Common
        {
            public static CCAPI CcApi;
            public static TMAPI TmApi;
            public static PS3MAPI Ps3mApi;
        }

       /// <summary>Init again the connection if you use a Thread or a Timer (TmApi Only).</summary>
        public void InitTarget()
        {
            if (SetAPI.API == SelectAPI.TargetManager)
                Common.TmApi.InitComms();
        }

        /// <summary>Connect your console with selected API.</summary>
        public bool ConnectTarget(int target = 0)
        {
            // We'll check again if the instance has been done, else you'll got an exception error.
            MakeInstanceAPI(GetCurrentAPI());

            bool result = false;
            if (SetAPI.API == SelectAPI.TargetManager)
                result = Common.TmApi.ConnectTarget(target);
            else if (SetAPI.API == SelectAPI.ControlConsole)
                result = new ConsoleList(this).Show();
            else if (SetAPI.API == SelectAPI.PS3Manager)
                result =  Common.Ps3mApi.ConnectTarget();
            return result;
        }

        /// <summary>Connect your console with ip (CcApi And Ps3mApi Only).</summary>
        public bool ConnectTarget(string ip)
        {
            // We'll check again if the instance has been done.
            MakeInstanceAPI(GetCurrentAPI());

            bool result = false;
            if (SetAPI.API == SelectAPI.ControlConsole)
                if (Common.CcApi.SUCCESS(Common.CcApi.ConnectTarget(ip)))
                {
                    targetIp = ip;
                    result = true;
                }
                else result = false;
            else if (SetAPI.API == SelectAPI.PS3Manager)
            {
                result = Common.Ps3mApi.ConnectTarget(ip);
                if (result) targetIp = ip;
            }
            return result;
        }

        /// <summary>Connect your console with ip and port (Ps3mApi Only).</summary>
        public bool ConnectTarget(string ip, int port)
        {
            // We'll check again if the instance has been done.
            MakeInstanceAPI(GetCurrentAPI());

            bool result = false;
            if (SetAPI.API == SelectAPI.PS3Manager)
            {
                result = Common.Ps3mApi.ConnectTarget(ip, port);
                if (result) targetIp = ip;
            }
            return result;
        }
        
        /// <summary>Disconnect Target with selected API.</summary>
        public void DisconnectTarget()
        {
            if (SetAPI.API == SelectAPI.TargetManager)
                Common.TmApi.DisconnectTarget();
            else if (SetAPI.API == SelectAPI.ControlConsole)
                Common.CcApi.DisconnectTarget();
            else if (SetAPI.API == SelectAPI.PS3Manager)
                Common.Ps3mApi.DisconnectTarget();
        }

        /// <summary>Attach the current process (current Game) with selected API.</summary>
        public bool AttachProcess()
        {
            // We'll check again if the instance has been done.
            MakeInstanceAPI(GetCurrentAPI());

            bool AttachResult = false;
            if (SetAPI.API == SelectAPI.TargetManager)
                AttachResult = Common.TmApi.AttachProcess();
            else if (SetAPI.API == SelectAPI.ControlConsole)
                AttachResult = Common.CcApi.SUCCESS(Common.CcApi.AttachProcess());
            else if (SetAPI.API == SelectAPI.PS3Manager)
                AttachResult = Common.Ps3mApi.AttachProcess();
            return AttachResult;
        }

        /// <summary>Return current console name.</summary>
        public string GetConsoleName()
        {
            if (SetAPI.API == SelectAPI.TargetManager)
                return Common.TmApi.SCE.GetTargetName();
            else if (SetAPI.API == SelectAPI.ControlConsole)
            {
                if (targetName != String.Empty)
                    return targetName;

                if (targetIp != String.Empty)
                {
                    List<CCAPI.ConsoleInfo> Data = new List<CCAPI.ConsoleInfo>();
                    Data = Common.CcApi.GetConsoleList();
                    if (Data.Count > 0)
                    {
                        for (int i = 0; i < Data.Count; i++)
                            if (Data[i].Ip == targetIp)
                                return Data[i].Name;
                    }
                }
                return targetIp;
            }
            else if (SetAPI.API == SelectAPI.PS3Manager)
                return "PS3 Manager API";
            else
                return "none";
        }

        /// <summary>Set memory to offset with selected API.</summary>
        public void SetMemory(uint offset, byte[] buffer)
        {
            if (SetAPI.API == SelectAPI.TargetManager)
                Common.TmApi.SetMemory(offset, buffer);
            else if (SetAPI.API == SelectAPI.ControlConsole)
                Common.CcApi.SetMemory(offset, buffer);
            else if (SetAPI.API == SelectAPI.PS3Manager)
                Common.Ps3mApi.SetMemory(offset, buffer);
        }

        /// <summary>Get memory from offset using the Selected API.</summary>
        public void GetMemory(uint offset, byte[] buffer)
        {
            if (SetAPI.API == SelectAPI.TargetManager)
                Common.TmApi.GetMemory(offset, buffer);
            else if (SetAPI.API == SelectAPI.ControlConsole)
                Common.CcApi.GetMemory(offset, buffer);
            else if (SetAPI.API == SelectAPI.PS3Manager)
                Common.Ps3mApi.GetMemory(offset, buffer);
        }

        /// <summary>Get memory from offset with a length using the Selected API.</summary>
        public byte[] GetBytes(uint offset, int length)
        {
            byte[] buffer = new byte[length];
            if (SetAPI.API == SelectAPI.TargetManager)
                Common.TmApi.GetMemory(offset, buffer);
            else if (SetAPI.API == SelectAPI.ControlConsole)
                Common.CcApi.GetMemory(offset, buffer);
            else if (SetAPI.API == SelectAPI.PS3Manager)
                Common.Ps3mApi.GetMemory(offset, buffer);
            return buffer;
        }

        /// <summary>Send Notifiction (CcApi And Ps3mApi Only).</summary>
        public void Notify(string msg, CCAPI.NotifyIcon icon = CCAPI.NotifyIcon.INFO)
        {
            if (SetAPI.API == SelectAPI.ControlConsole)
                Common.CcApi.Notify(icon, msg);
            else if (SetAPI.API == SelectAPI.PS3Manager)
                Common.Ps3mApi.Notify(msg);
        }

        public enum PowerFlags
        {
            ShutDown,
            QuickReboot,
            SoftReboot,
            HardReboot
        }

        /// <summary>You can shutdown the console or just reboot her according the flag selected (CcApi And Ps3mApi Only).</summary>
        public void Power(PowerFlags flag)
        {
            if (SetAPI.API == SelectAPI.ControlConsole)
            {
                if (flag == PowerFlags.ShutDown) Common.CcApi.ShutDown(CCAPI.RebootFlags.ShutDown);
                else if (flag == PowerFlags.QuickReboot) Common.CcApi.ShutDown(CCAPI.RebootFlags.SoftReboot);
                else if (flag == PowerFlags.SoftReboot) Common.CcApi.ShutDown(CCAPI.RebootFlags.SoftReboot);
                else if (flag == PowerFlags.HardReboot) Common.CcApi.ShutDown(CCAPI.RebootFlags.HardReboot);
            }
            else if (SetAPI.API == SelectAPI.PS3Manager)
            {
                if (flag == PowerFlags.ShutDown)  Common.Ps3mApi.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.ShutDown);
                else if (flag == PowerFlags.QuickReboot)  Common.Ps3mApi.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.QuickReboot);
                else if (flag == PowerFlags.SoftReboot)  Common.Ps3mApi.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.SoftReboot);
                else if (flag == PowerFlags.HardReboot)  Common.Ps3mApi.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.ShutDown);
            }
        }

        public enum BuzzerMode
        {
            Single,
            Double,
            Triple
        }

        /// <summary>Your console will emit a song (CcApi And Ps3mApi Only).</summary>
        public void Buzzer(BuzzerMode flag)
        {
            if (SetAPI.API == SelectAPI.ControlConsole)
            {
                if (flag == BuzzerMode.Single) Common.CcApi.RingBuzzer(CCAPI.BuzzerMode.Single);
                else if (flag == BuzzerMode.Double) Common.CcApi.RingBuzzer(CCAPI.BuzzerMode.Double);
                else if (flag == BuzzerMode.Triple) Common.CcApi.RingBuzzer(CCAPI.BuzzerMode.Continuous);
            }
            else if (SetAPI.API == SelectAPI.PS3Manager)
            {
                if (flag == BuzzerMode.Single) Common.Ps3mApi.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Single);
                else if (flag == BuzzerMode.Double) Common.Ps3mApi.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Double);
                else if (flag == BuzzerMode.Triple) Common.Ps3mApi.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Triple);
            }
        }

        public enum LedColor
        {
            Red,
            Green,
            Yellow
        }

        public enum LedMode
        {
            Off,
            On,
            BlinkSlow,
            BlinkFast
        }

        /// <summary>Change leds for your console.</summary>
        public void Led(LedColor color, LedMode mode)
        {
            if (SetAPI.API == SelectAPI.ControlConsole)
            {
                if (color == LedColor.Red && mode == LedMode.Off) Common.CcApi.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.Off);
                else if (color == LedColor.Red && mode == LedMode.On) Common.CcApi.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.On);
                else if (color == LedColor.Red && mode == LedMode.BlinkFast) Common.CcApi.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.Blink);
                else if (color == LedColor.Red && mode == LedMode.BlinkSlow) Common.CcApi.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.Blink);
                else if (color == LedColor.Green && mode == LedMode.Off) Common.CcApi.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.Off);
                else if (color == LedColor.Green && mode == LedMode.On) Common.CcApi.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.On);
                else if (color == LedColor.Green && mode == LedMode.BlinkFast) Common.CcApi.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.Blink);
                else if (color == LedColor.Green && mode == LedMode.BlinkSlow) Common.CcApi.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.Blink);
                else if (color == LedColor.Yellow && mode == LedMode.Off) Common.CcApi.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.Off);
                else if (color == LedColor.Yellow && mode == LedMode.On) Common.CcApi.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.On);
                else if (color == LedColor.Yellow && mode == LedMode.BlinkFast) Common.CcApi.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.Blink);
                else if (color == LedColor.Yellow && mode == LedMode.BlinkSlow) Common.CcApi.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.Blink);
            }
            else if (SetAPI.API == SelectAPI.PS3Manager)
            {
                if (color == LedColor.Red && mode == LedMode.Off) Common.Ps3mApi.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.Off);
                else if (color == LedColor.Red && mode == LedMode.On) Common.Ps3mApi.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.On);
                else if (color == LedColor.Red && mode == LedMode.BlinkFast) Common.Ps3mApi.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkFast);
                else if (color == LedColor.Red && mode == LedMode.BlinkSlow) Common.Ps3mApi.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkSlow);
                else if (color == LedColor.Green && mode == LedMode.Off) Common.Ps3mApi.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.Off);
                else if (color == LedColor.Green && mode == LedMode.On) Common.Ps3mApi.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.On);
                else if (color == LedColor.Green && mode == LedMode.BlinkFast) Common.Ps3mApi.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkFast);
                else if (color == LedColor.Green && mode == LedMode.BlinkSlow) Common.Ps3mApi.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkSlow);
                else if (color == LedColor.Yellow && mode == LedMode.Off) Common.Ps3mApi.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Yellow, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.Off);
                else if (color == LedColor.Yellow && mode == LedMode.On) Common.Ps3mApi.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Yellow, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.On);
                else if (color == LedColor.Yellow && mode == LedMode.BlinkFast) Common.Ps3mApi.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Yellow, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkFast);
                else if (color == LedColor.Yellow && mode == LedMode.BlinkSlow) Common.Ps3mApi.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Yellow, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkSlow);
            }
        }

        /// <summary>Change current API.</summary>
        public void ChangeAPI(SelectAPI API)
        {
            SetAPI.API = API;
            MakeInstanceAPI(GetCurrentAPI());
        }

        /// <summary>Return selected API.</summary>
        public SelectAPI GetCurrentAPI()
        {
            return SetAPI.API;
        }

        /// <summary>Return selected API into string format.</summary>
        public string GetCurrentAPIName()
        {
            string output = String.Empty;
            if (SetAPI.API == SelectAPI.TargetManager)
                output = Enum.GetName(typeof(SelectAPI), SelectAPI.TargetManager).Replace("Manager"," Manager");
            else if (SetAPI.API == SelectAPI.ControlConsole) 
                output = Enum.GetName(typeof(SelectAPI), SelectAPI.ControlConsole).Replace("Console", " Console");
            else if (SetAPI.API == SelectAPI.PS3Manager)
                output = Enum.GetName(typeof(SelectAPI), SelectAPI.PS3Manager).Replace("Manager", " Manager");
            return output;
        }

        /// <summary>This will find the dll ps3tmapi_net.dll for TMAPI.</summary>
        public Assembly PS3TMAPI_NET()
        {
            return Common.TmApi.PS3TMAPI_NET();
        }

        /// <summary>Use the extension class with your selected API.</summary>
        public Extension Extension
        {
            get { return new Extension(SetAPI.API); }
        }

        /// <summary>Access to all TMAPI functions.</summary>
        public TMAPI TMAPI
        {
            get { return new TMAPI(); }
        }

        /// <summary>Access to all CCAPI functions.</summary>
        public CCAPI CCAPI
        {
            get { return new CCAPI(); }
        }

        /// <summary>Access to all PS3MAPI functions.</summary>
        public PS3MAPI PS3MAPI
        {
            get { return new PS3MAPI(); }
        }

    }
}
