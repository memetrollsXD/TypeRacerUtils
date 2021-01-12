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
using WindowsInput;
using WindowsInput.Native;

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
            gkh.HookedKeys.Add(Keys.Back);
            gkh.HookedKeys.Add(Keys.B);
            gkh.HookedKeys.Add(Keys.C);
            gkh.HookedKeys.Add(Keys.D);
            gkh.HookedKeys.Add(Keys.E);
            gkh.HookedKeys.Add(Keys.F);
            gkh.HookedKeys.Add(Keys.G);
            gkh.HookedKeys.Add(Keys.H);
            gkh.HookedKeys.Add(Keys.I);
            gkh.HookedKeys.Add(Keys.J);
            gkh.HookedKeys.Add(Keys.K);
            gkh.HookedKeys.Add(Keys.L);
            gkh.HookedKeys.Add(Keys.M);
            gkh.HookedKeys.Add(Keys.N);
            gkh.HookedKeys.Add(Keys.O);
            gkh.HookedKeys.Add(Keys.Q);
            gkh.HookedKeys.Add(Keys.R);
            gkh.HookedKeys.Add(Keys.T);
            gkh.HookedKeys.Add(Keys.U);
            gkh.HookedKeys.Add(Keys.V);
            gkh.HookedKeys.Add(Keys.W);
            gkh.HookedKeys.Add(Keys.X);
            gkh.HookedKeys.Add(Keys.Y);
            gkh.HookedKeys.Add(Keys.Z);
            gkh.HookedKeys.Add(Keys.Alt);
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
        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (backBox.Checked)
            {
                if (e.KeyCode.ToString() == "Back")
                {
                    InputSimulator sim = new InputSimulator();
                    sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_A);
                }
            }
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
                    InputSimulator imp = new InputSimulator();
                    imp.Keyboard.KeyPress(VirtualKeyCode.CAPITAL);
                } else
                {
                    return;
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
        }
        void Print(string str)
        {
            outputBox.Text = str;
        }

        private void topBox_CheckedChanged(object sender, EventArgs e)
        {
            if (topBox.Checked)
            {
                this.TopMost = true;
            } else
            {
                this.TopMost = false;
            }
        }

    }
}
