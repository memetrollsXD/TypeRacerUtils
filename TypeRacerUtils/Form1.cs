using System;
using Utilities;
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

namespace TypeRacerUtils
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gkh.HookedKeys.Add(Keys.LControlKey);
            gkh.HookedKeys.Add(Keys.RControlKey);
            gkh.HookedKeys.Add(Keys.S);
            gkh.HookedKeys.Add(Keys.P);
            gkh.HookedKeys.Add(Keys.A);
            gkh.HookedKeys.Add(Keys.CapsLock);
            gkh.HookedKeys.Add(Keys.LShiftKey);
            gkh.HookedKeys.Add(Keys.RShiftKey);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
            hooked = true;
            Print("Successfully Hooked!");
        }
        [DllImport("user32.dll")]
    static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        globalKeyboardHook gkh = new globalKeyboardHook();
        public bool hooked;
        private void hookBtn_Click(object sender, EventArgs e)
        {
            if (!hooked)
            {
                gkh.hook();
                hooked = true;
                hookBtn.Text = "Unhook";
                Print("Successfully Hooked!");
            }
            else
            {
                gkh.unhook();
                hooked = false;
                hookBtn.Text = "Hook";
                Print("Successfully Unhooked!");
            }
        }
        public bool holdctrl;
        public bool holdshft;
        public int count = 0;
        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
         /*   if (shiftBox.Checked)
            {
                if (e.KeyCode.ToString() == "LShiftKey" | e.KeyCode.ToString() == "RShiftKey")
                {
                    holdshft = true;
                }
                if(holdshft)
                {
                    count++;
                    
                    if (count < 1)
                    {
                        e.Handled = true;
                    }
                }
            } */
            if (shortBox.Checked)
            {
                if (e.KeyCode.ToString() == "LControlKey" | e.KeyCode.ToString() == "RControlKey")
                {
                    holdctrl = true;
                }
                if(holdctrl) {
                    if (e.KeyCode.ToString() == "S" | e.KeyCode.ToString() == "P")
                    {
                        e.Handled = true;
                    }
                }
            }
            if (capsBox.Checked)
            {
                if (Control.IsKeyLocked(Keys.CapsLock)) // Checks Capslock is on
                {
                    const int KEYEVENTF_EXTENDEDKEY = 0x1;
                    const int KEYEVENTF_KEYUP = 0x2;
                    keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                    keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP,
                    (UIntPtr)0);
                }
            }
        }
        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (shortBox.Checked)
            {
                if (e.KeyCode.ToString() == "LControlKey" | e.KeyCode.ToString() == "RControlKey")
                {
                    holdctrl = false;
                }
            }
            /* if (shiftBox.Checked)
            {
                if (e.KeyCode.ToString() == "LShiftKey" | e.KeyCode.ToString() == "RShiftKey")
                {
                    holdshft = false;
                    count = 0;
                } 
            } */
        }
        void Print(string str)
        {
            outputBox.Text = str;
        }
    }
}
