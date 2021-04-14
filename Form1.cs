using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;


namespace Dll___Fixer___2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Chave = "Fr33d0m";
        string Creditos = "@{/< Miecn";
        int TotalDllCorrigidas = 0;

        string XOR_Encryption(string toBeEncrypted, string sKey)
        {
            StringBuilder sb = new StringBuilder();
            int iKey = (sKey.Length), iIn = (toBeEncrypted.Length), x = (0);

            for (int i = 0; i < iIn; i++)
            {
                sb.Append((char)(toBeEncrypted[i] ^ sKey[x] & 10));
                if (++x == iKey) { x = 0; }
            }

            return sb.ToString();
        }

        string Dll1_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_24.dll",
           Dll2_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_25.dll",
           Dll3_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_26.dll",
           Dll4_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_27.dll",
           Dll5_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_28.dll",
           Dll6_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_29.dll",
           Dll7_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_30.dll",
           Dll8_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_31.dll",
           Dll9_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_32.dll",
           Dll10_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_33.dll",
           Dll11_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_34.dll",
           Dll12_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_35.dll",
           Dll13_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_36.dll",
           Dll14_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_37.dll",
           Dll15_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_38.dll",
           Dll16_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_39.dll",
           Dll17_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_40.dll",
           Dll18_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_41.dll",
           Dll19_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_42.dll",
           Dll20_x86 = "C:\\Windows\\" + "System32" + "\\d3dx9_43.dll",
           Dll21_x86 = "C:\\Windows\\" + "System32" + "\\d3dx10.dll",
           Dll22_x86 = "C:\\Windows\\" + "System32" + "\\d3dx10_33.dll",
           Dll23_x86 = "C:\\Windows\\" + "System32" + "\\d3dx10_34.dll",
           Dll24_x86 = "C:\\Windows\\" + "System32" + "\\d3dx10_35.dll",
           Dll25_x86 = "C:\\Windows\\" + "System32" + "\\d3dx10_36.dll",
           Dll26_x86 = "C:\\Windows\\" + "System32" + "\\d3dx10_37.dll",
           Dll27_x86 = "C:\\Windows\\" + "System32" + "\\d3dx10_38.dll",
           Dll28_x86 = "C:\\Windows\\" + "System32" + "\\d3dx10_39.dll",
           Dll29_x86 = "C:\\Windows\\" + "System32" + "\\d3dx10_40.dll",
           Dll30_x86 = "C:\\Windows\\" + "System32" + "\\d3dx10_41.dll",
           Dll31_x86 = "C:\\Windows\\" + "System32" + "\\d3dx10_42.dll",
           Dll32_x86 = "C:\\Windows\\" + "System32" + "\\d3dx10_43.dll",
           Dll33_x86 = "C:\\Windows\\" + "System32" + "\\d3dx11_42.dll",
           Dll34_x86 = "C:\\Windows\\" + "System32" + "\\d3dx11_43.dll",
           Dll35_x86 = "C:\\Windows\\" + "System32" + "\\msvcp100.dll",
           Dll36_x86 = "C:\\Windows\\" + "System32" + "\\msvcp100d.dll",
           Dll37_x86 = "C:\\Windows\\" + "System32" + "\\msvcp110.dll",
           Dll38_x86 = "C:\\Windows\\" + "System32" + "\\msvcp110_clr0400.dll",
           Dll39_x86 = "C:\\Windows\\" + "System32" + "\\msvcp110_win.dll",
           Dll40_x86 = "C:\\Windows\\" + "System32" + "\\msvcp110d.dll",
           Dll41_x86 = "C:\\Windows\\" + "System32" + "\\msvcp120.dll",
           Dll42_x86 = "C:\\Windows\\" + "System32" + "\\msvcp120_clr0400.dll",
           Dll43_x86 = "C:\\Windows\\" + "System32" + "\\msvcp120d.dll",
           Dll44_x86 = "C:\\Windows\\" + "System32" + "\\msvcp140.dll",
           Dll45_x86 = "C:\\Windows\\" + "System32" + "\\msvcp140d.dll",
           Dll46_x86 = "C:\\Windows\\" + "System32" + "\\msvcr71.dll",
           Dll47_x86 = "C:\\Windows\\" + "System32" + "\\msvcr71d.dll",
           Dll48_x86 = "C:\\Windows\\" + "System32" + "\\msvcr100.dll",
           Dll49_x86 = "C:\\Windows\\" + "System32" + "\\msvcr100_clr0400.dll",
           Dll50_x86 = "C:\\Windows\\" + "System32" + "\\msvcr100d.dll",
           Dll51_x86 = "C:\\Windows\\" + "System32" + "\\msvcr110.dll",
           Dll52_x86 = "C:\\Windows\\" + "System32" + "\\msvcr110_clr0400.dll",
           Dll53_x86 = "C:\\Windows\\" + "System32" + "\\msvcr110d.dll",
           Dll54_x86 = "C:\\Windows\\" + "System32" + "\\msvcr120.dll",
           Dll55_x86 = "C:\\Windows\\" + "System32" + "\\xinput1_1.dll",
           Dll56_x86 = "C:\\Windows\\" + "System32" + "\\xinput1_2.dll",
           Dll57_x86 = "C:\\Windows\\" + "System32" + "\\xinput1_3.dll",
           Dll58_x86 = "C:\\Windows\\" + "System32" + "\\api-ms-win-crt-runtime-l1-1-0.dll",
           Dll59_x86 = "C:\\Windows\\" + "System32" + "\\msvcp70.dll",
           Dll60_x86 = "C:\\Windows\\" + "System32" + "\\msvcp71.dll",
           Dll61_x86 = "C:\\Windows\\" + "System32" + "\\msvcp71d.dll",
           Dll62_x86 = "C:\\Windows\\" + "System32" + "\\msvcp80.dll",
           Dll63_x86 = "C:\\Windows\\" + "System32" + "\\msvcp80d.dll",
           Dll64_x86 = "C:\\Windows\\" + "System32" + "\\msvcp90.dll",
           Dll65_x86 = "C:\\Windows\\" + "System32" + "\\x3daudio1_0.dll",
           Dll66_x86 = "C:\\Windows\\" + "System32" + "\\X3DAudio1_1.dll",
           Dll67_x86 = "C:\\Windows\\" + "System32" + "\\X3DAudio1_2.dll",
           Dll68_x86 = "C:\\Windows\\" + "System32" + "\\X3DAudio1_3.dll",
           Dll69_x86 = "C:\\Windows\\" + "System32" + "\\X3DAudio1_4.dll",
           Dll70_x86 = "C:\\Windows\\" + "System32" + "\\X3DAudio1_5.dll",
           Dll71_x86 = "C:\\Windows\\" + "System32" + "\\X3DAudio1_6.dll",
           Dll72_x86 = "C:\\Windows\\" + "System32" + "\\X3DAudio1_7.dll",
           Dll73_x86 = "C:\\Windows\\" + "System32" + "\\xinput1_4.dll",
           Dll74_x86 = "C:\\Windows\\" + "System32" + "\\msvcr80.dll",
           Dll75_x86 = "C:\\Windows\\" + "System32" + "\\msvcr80d.dll",
           Dll76_x86 = "C:\\Windows\\" + "System32" + "\\msvcr90.dll",
           Dll77_x86 = "C:\\Windows\\" + "System32" + "\\msvcr90d.dll",
           Dll78_x86 = "C:\\Windows\\" + "System32" + "\\msvcr120_clr0400.dll",
           Dll79_x86 = "C:\\Windows\\" + "System32" + "\\msvcr120d.dll",
           Dll80_x86 = "C:\\Windows\\" + "System32" + "\\msvcrt.dll",
           Dll81_x86 = "C:\\Windows\\" + "System32" + "\\D3DCompiler_33.dll",
           Dll82_x86 = "C:\\Windows\\" + "System32" + "\\D3DCompiler_34.dll",
           Dll83_x86 = "C:\\Windows\\" + "System32" + "\\D3DCompiler_35.dll",
           Dll84_x86 = "C:\\Windows\\" + "System32" + "\\D3DCompiler_36.dll",
           Dll85_x86 = "C:\\Windows\\" + "System32" + "\\D3DCompiler_37.dll",
           Dll86_x86 = "C:\\Windows\\" + "System32" + "\\D3DCompiler_38.dll",
           Dll87_x86 = "C:\\Windows\\" + "System32" + "\\D3DCompiler_39.dll",
           Dll88_x86 = "C:\\Windows\\" + "System32" + "\\D3DCompiler_40.dll",
           Dll89_x86 = "C:\\Windows\\" + "System32" + "\\D3DCompiler_41.dll",
           Dll90_x86 = "C:\\Windows\\" + "System32" + "\\D3DCompiler_42.dll",
           Dll91_x86 = "C:\\Windows\\" + "System32" + "\\D3DCompiler_43.dll",
           Dll95_x86 = "C:\\Windows\\" + "System32" + "\\D3DCompiler_47.dll";


        string Dll1_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_24.dll",
           Dll2_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_25.dll",
           Dll3_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_26.dll",
           Dll4_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_27.dll",
           Dll5_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_28.dll",
           Dll6_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_29.dll",
           Dll7_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_30.dll",
           Dll8_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_31.dll",
           Dll9_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_32.dll",
           Dll10_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_33.dll",
           Dll11_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_34.dll",
           Dll12_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_35.dll",
           Dll13_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_36.dll",
           Dll14_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_37.dll",
           Dll15_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_38.dll",
           Dll16_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_39.dll",
           Dll17_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_40.dll",
           Dll18_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_41.dll",
           Dll19_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_42.dll",
           Dll20_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx9_43.dll",
           Dll21_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx10.dll",
           Dll22_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx10_33.dll",
           Dll23_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx10_34.dll",
           Dll24_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx10_35.dll",
           Dll25_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx10_36.dll",
           Dll26_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx10_37.dll",
           Dll27_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx10_38.dll",
           Dll28_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx10_39.dll",
           Dll29_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx10_40.dll",
           Dll30_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx10_41.dll",
           Dll31_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx10_42.dll",
           Dll32_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx10_43.dll",
           Dll33_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx11_42.dll",
           Dll34_x64 = "C:\\Windows\\" + "SysWOW64" + "\\d3dx11_43.dll",
           Dll35_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp100.dll",
           Dll36_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp100d.dll",
           Dll37_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp110.dll",
           Dll38_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp110_clr0400.dll",
           Dll39_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp110_win.dll",
           Dll40_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp110d.dll",
           Dll41_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp120.dll",
           Dll42_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp120_clr0400.dll",
           Dll43_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp120d.dll",
           Dll44_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp140.dll",
           Dll45_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp140d.dll",
           Dll46_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr71.dll",
           Dll47_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr71d.dll",
           Dll48_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr100.dll",
           Dll49_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr100_clr0400.dll",
           Dll50_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr100d.dll",
           Dll51_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr110.dll",
           Dll52_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr110_clr0400.dll",
           Dll53_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr110d.dll",
           Dll54_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr120.dll",
           Dll55_x64 = "C:\\Windows\\" + "SysWOW64" + "\\xinput1_1.dll",
           Dll56_x64 = "C:\\Windows\\" + "SysWOW64" + "\\xinput1_2.dll",
           Dll57_x64 = "C:\\Windows\\" + "SysWOW64" + "\\xinput1_3.dll",
           Dll58_x64 = "C:\\Windows\\" + "SysWOW64" + "\\api-ms-win-crt-runtime-l1-1-0.dll",
           Dll59_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp70.dll",
           Dll60_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp71.dll",
           Dll61_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp71d.dll",
           Dll62_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp80.dll",
           Dll63_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp80d.dll",
           Dll64_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcp90.dll",
           Dll65_x64 = "C:\\Windows\\" + "SysWOW64" + "\\x3daudio1_0.dll",
           Dll66_x64 = "C:\\Windows\\" + "SysWOW64" + "\\X3DAudio1_1.dll",
           Dll67_x64 = "C:\\Windows\\" + "SysWOW64" + "\\X3DAudio1_2.dll",
           Dll68_x64 = "C:\\Windows\\" + "SysWOW64" + "\\X3DAudio1_3.dll",
           Dll69_x64 = "C:\\Windows\\" + "SysWOW64" + "\\X3DAudio1_4.dll",
           Dll70_x64 = "C:\\Windows\\" + "SysWOW64" + "\\X3DAudio1_5.dll",
           Dll71_x64 = "C:\\Windows\\" + "SysWOW64" + "\\X3DAudio1_6.dll",
           Dll72_x64 = "C:\\Windows\\" + "SysWOW64" + "\\X3DAudio1_7.dll",
           Dll73_x64 = "C:\\Windows\\" + "SysWOW64" + "\\xinput1_4.dll",
           Dll74_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr80.dll",
           Dll75_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr80d.dll",
           Dll76_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr90.dll",
           Dll77_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr90d.dll",
           Dll78_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr120_clr0400.dll",
           Dll79_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcr120d.dll",
           Dll80_x64 = "C:\\Windows\\" + "SysWOW64" + "\\msvcrt.dll",
           Dll81_x64 = "C:\\Windows\\" + "SysWOW64" + "\\D3DCompiler_33.dll",
           Dll82_x64 = "C:\\Windows\\" + "SysWOW64" + "\\D3DCompiler_34.dll",
           Dll83_x64 = "C:\\Windows\\" + "SysWOW64" + "\\D3DCompiler_35.dll",
           Dll84_x64 = "C:\\Windows\\" + "SysWOW64" + "\\D3DCompiler_36.dll",
           Dll85_x64 = "C:\\Windows\\" + "SysWOW64" + "\\D3DCompiler_37.dll",
           Dll86_x64 = "C:\\Windows\\" + "SysWOW64" + "\\D3DCompiler_38.dll",
           Dll87_x64 = "C:\\Windows\\" + "SysWOW64" + "\\D3DCompiler_39.dll",
           Dll88_x64 = "C:\\Windows\\" + "SysWOW64" + "\\D3DCompiler_40.dll",
           Dll89_x64 = "C:\\Windows\\" + "SysWOW64" + "\\D3DCompiler_41.dll",
           Dll90_x64 = "C:\\Windows\\" + "SysWOW64" + "\\D3DCompiler_42.dll",
           Dll91_x64 = "C:\\Windows\\" + "SysWOW64" + "\\D3DCompiler_43.dll",
           Dll95_x64 = "C:\\Windows\\" + "SysWOW64" + "\\D3DCompiler_47.dll";


        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\Dlls_x64.zip") == true)
            {
                File.Delete(Application.StartupPath + "\\Dlls_x64.zip");
            }
            if (Directory.Exists(Application.StartupPath + "\\Dlls") == true)
            {
                Directory.Delete(Application.StartupPath + "\\Dlls", true);
            }
            if (Environment.Is64BitOperatingSystem == true)
            {
                Timer_Principal.Enabled = true;
                Timer_Principal.Start();
                lb_Status.Text = "Analizando seu Sistema! Aguarde.";
            }
            else
            {
                MessageBox.Show("Essa não é a versão funcional para seu Windows!\nBaixe a Versão 32bits (x86).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }


        private void Timer_Principal_Tick(object sender, EventArgs e)
        {
            File.WriteAllBytes(Application.StartupPath + "\\Dlls_x64.zip", Properties.Resources.Dlls_x64);
            ZipFile.ExtractToDirectory(Application.StartupPath + "\\Dlls_x64.zip", Application.StartupPath);
            File.Delete(Application.StartupPath + "\\Dlls_x64.zip");

            if (Environment.Is64BitOperatingSystem == true)
            {
                if (File.Exists(Dll1_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_24.dll", Dll1_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll2_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_25.dll", Dll2_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll3_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_26.dll", Dll3_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll4_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_27.dll", Dll4_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll5_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_28.dll", Dll5_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll6_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_29.dll", Dll6_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll7_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_30.dll", Dll7_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll8_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_31.dll", Dll8_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll9_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_32.dll", Dll9_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll10_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_33.dll", Dll10_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll11_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_34.dll", Dll11_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll12_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_35.dll", Dll12_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll13_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_36.dll", Dll13_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll14_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_37.dll", Dll14_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll15_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_38.dll", Dll15_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll16_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_39.dll", Dll16_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll17_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_40.dll", Dll17_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll18_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_41.dll", Dll18_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll19_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_42.dll", Dll19_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll20_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_43.dll", Dll20_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll21_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10.dll", Dll21_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll22_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_33.dll", Dll22_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll23_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_34.dll", Dll23_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll24_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_35.dll", Dll24_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll25_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_36.dll", Dll25_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll26_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_37.dll", Dll26_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll27_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_38.dll", Dll27_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll28_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_39.dll", Dll28_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll29_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_40.dll", Dll29_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll30_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_41.dll", Dll30_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll31_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_42.dll", Dll31_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll32_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_43.dll", Dll32_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll33_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx11_42.dll", Dll33_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll34_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx11_43.dll", Dll34_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll35_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp100.dll", Dll35_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll36_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp100d.dll", Dll36_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll37_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp110.dll", Dll37_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll38_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp110_clr0400.dll", Dll38_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll39_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp110_win.dll", Dll39_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll40_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp110d.dll", Dll40_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll41_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp120.dll", Dll41_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll42_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp120_clr0400.dll", Dll42_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll43_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp120d.dll", Dll43_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll44_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp140.dll", Dll44_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll45_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp140d.dll", Dll45_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll46_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr71.dll", Dll46_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll47_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr71d.dll", Dll47_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll48_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr100.dll", Dll48_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll49_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr100_clr0400.dll", Dll49_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll50_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr100d.dll", Dll50_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll51_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr110.dll", Dll51_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll52_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr110_clr0400.dll", Dll52_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll53_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr110d.dll", Dll53_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll54_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr120.dll", Dll54_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll55_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\xinput1_1.dll", Dll55_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll56_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\xinput1_2.dll", Dll56_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll57_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\xinput1_3.dll", Dll57_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll58_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\api-ms-win-crt-runtime-l1-1-0.dll", Dll58_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll59_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp70.dll", Dll59_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll60_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp71.dll", Dll60_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll61_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp71d.dll", Dll61_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll62_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp80.dll", Dll62_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll63_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp80d.dll", Dll63_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll64_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp90.dll", Dll64_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll65_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\x3daudio1_0.dll", Dll65_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll66_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_1.dll", Dll66_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll67_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_2.dll", Dll67_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll68_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_3.dll", Dll68_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll69_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_4.dll", Dll69_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll70_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_5.dll", Dll70_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll71_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_6.dll", Dll71_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll72_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_7.dll", Dll72_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll73_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\xinput1_4.dll", Dll73_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll74_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr80.dll", Dll74_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll75_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr80d.dll", Dll75_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll76_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr90.dll", Dll76_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll77_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr90d.dll", Dll77_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll78_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr120_clr0400.dll", Dll78_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll79_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr120d.dll", Dll79_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll80_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcrt.dll", Dll80_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll81_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_33.dll", Dll81_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll82_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_34.dll", Dll82_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll83_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_35.dll", Dll83_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll84_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_36.dll", Dll84_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll85_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_37.dll", Dll85_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll86_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_38.dll", Dll86_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll87_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_39.dll", Dll87_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll88_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_40.dll", Dll88_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll89_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_41.dll", Dll89_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll90_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_42.dll", Dll90_x86);
                    TotalDllCorrigidas++;
                }

                if (File.Exists(Dll91_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_43.dll", Dll91_x86);
                    TotalDllCorrigidas++;
                }


                if (File.Exists(Dll95_x86) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_47.dll", Dll95_x86);
                    TotalDllCorrigidas++;
                }


                if (File.Exists(Dll1_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_24.dll", Dll1_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll2_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_25.dll", Dll2_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll3_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_26.dll", Dll3_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll4_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_27.dll", Dll4_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll5_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_28.dll", Dll5_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll6_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_29.dll", Dll6_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll7_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_30.dll", Dll7_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll8_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_31.dll", Dll8_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll9_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_32.dll", Dll9_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll10_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_33.dll", Dll10_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll11_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_34.dll", Dll11_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll12_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_35.dll", Dll12_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll13_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_36.dll", Dll13_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll14_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_37.dll", Dll14_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll15_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_38.dll", Dll15_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll16_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_39.dll", Dll16_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll17_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_40.dll", Dll17_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll18_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_41.dll", Dll18_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll19_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_42.dll", Dll19_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll20_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx9_43.dll", Dll20_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll21_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10.dll", Dll21_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll22_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_33.dll", Dll22_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll23_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_34.dll", Dll23_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll24_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_35.dll", Dll24_x64); TotalDllCorrigidas++;

                }

                if (File.Exists(Dll25_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_36.dll", Dll25_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll26_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_37.dll", Dll26_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll27_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_38.dll", Dll27_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll28_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_39.dll", Dll28_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll29_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_40.dll", Dll29_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll30_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_41.dll", Dll30_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll31_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_42.dll", Dll31_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll32_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx10_43.dll", Dll32_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll33_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx11_42.dll", Dll33_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll34_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\d3dx11_43.dll", Dll34_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll35_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp100.dll", Dll35_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll36_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp100d.dll", Dll36_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll37_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp110.dll", Dll37_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll38_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp110_clr0400.dll", Dll38_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll39_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp110_win.dll", Dll39_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll40_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp110d.dll", Dll40_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll41_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp120.dll", Dll41_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll42_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp120_clr0400.dll", Dll42_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll43_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp120d.dll", Dll43_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll44_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp140.dll", Dll44_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll45_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp140d.dll", Dll45_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll46_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr71.dll", Dll46_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll47_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr71d.dll", Dll47_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll48_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr100.dll", Dll48_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll49_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr100_clr0400.dll", Dll49_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll50_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr100d.dll", Dll50_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll51_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr110.dll", Dll51_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll52_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr110_clr0400.dll", Dll52_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll53_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr110d.dll", Dll53_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll54_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr120.dll", Dll54_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll55_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\xinput1_1.dll", Dll55_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll56_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\xinput1_2.dll", Dll56_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll57_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\xinput1_3.dll", Dll57_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll58_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\api-ms-win-crt-runtime-l1-1-0.dll", Dll58_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll59_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp70.dll", Dll59_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll60_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp71.dll", Dll60_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll61_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp71d.dll", Dll61_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll62_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp80.dll", Dll62_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll63_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp80d.dll", Dll63_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll64_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcp90.dll", Dll64_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll65_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\x3daudio1_0.dll", Dll65_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll66_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_1.dll", Dll66_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll67_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_2.dll", Dll67_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll68_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_3.dll", Dll68_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll69_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_4.dll", Dll69_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll70_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_5.dll", Dll70_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll71_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_6.dll", Dll71_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll72_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\X3DAudio1_7.dll", Dll72_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll73_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\xinput1_4.dll", Dll73_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll74_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr80.dll", Dll74_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll75_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr80d.dll", Dll75_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll76_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr90.dll", Dll76_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll77_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr90d.dll", Dll77_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll78_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr120_clr0400.dll", Dll78_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll79_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcr120d.dll", Dll79_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll80_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\msvcrt.dll", Dll80_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll81_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_33.dll", Dll81_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll82_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_34.dll", Dll82_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll83_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_35.dll", Dll83_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll84_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_36.dll", Dll84_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll85_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_37.dll", Dll85_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll86_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_38.dll", Dll86_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll87_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_39.dll", Dll87_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll88_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_40.dll", Dll88_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll89_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_41.dll", Dll89_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll90_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_42.dll", Dll90_x64); TotalDllCorrigidas++;
                }

                if (File.Exists(Dll91_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_43.dll", Dll91_x64); TotalDllCorrigidas++;
                }


                if (File.Exists(Dll95_x64) == false)
                {
                    File.Copy(Application.StartupPath + "\\Dlls\\x64\\D3DCompiler_47.dll", Dll95_x64); TotalDllCorrigidas++;
                }


                if (File.Exists(Dll1_x86) == true && File.Exists(Dll2_x86) == true && File.Exists(Dll3_x86) == true &&
                    File.Exists(Dll4_x86) == true && File.Exists(Dll5_x86) == true && File.Exists(Dll6_x86) == true &&
                    File.Exists(Dll7_x86) == true && File.Exists(Dll8_x86) == true && File.Exists(Dll9_x86) == true &&
                    File.Exists(Dll10_x86) == true && File.Exists(Dll11_x86) == true && File.Exists(Dll12_x86) == true &&
                    File.Exists(Dll13_x86) == true && File.Exists(Dll14_x86) == true && File.Exists(Dll15_x86) == true &&
                    File.Exists(Dll16_x86) == true && File.Exists(Dll17_x86) == true && File.Exists(Dll18_x86) == true &&
                    File.Exists(Dll19_x86) == true && File.Exists(Dll20_x86) == true && File.Exists(Dll21_x86) == true &&
                    File.Exists(Dll22_x86) == true && File.Exists(Dll23_x86) == true && File.Exists(Dll24_x86) == true &&
                    File.Exists(Dll25_x86) == true && File.Exists(Dll26_x86) == true && File.Exists(Dll27_x86) == true &&
                    File.Exists(Dll28_x86) == true && File.Exists(Dll29_x86) == true && File.Exists(Dll30_x86) == true &&
                    File.Exists(Dll31_x86) == true && File.Exists(Dll32_x86) == true && File.Exists(Dll33_x86) == true &&
                    File.Exists(Dll34_x86) == true && File.Exists(Dll35_x86) == true && File.Exists(Dll36_x86) == true &&
                    File.Exists(Dll37_x86) == true && File.Exists(Dll38_x86) == true && File.Exists(Dll39_x86) == true &&
                    File.Exists(Dll40_x86) == true && File.Exists(Dll41_x86) == true && File.Exists(Dll42_x86) == true &&
                    File.Exists(Dll43_x86) == true && File.Exists(Dll44_x86) == true && File.Exists(Dll45_x86) == true &&
                    File.Exists(Dll46_x86) == true && File.Exists(Dll47_x86) == true && File.Exists(Dll48_x86) == true &&
                    File.Exists(Dll49_x86) == true && File.Exists(Dll50_x86) == true && File.Exists(Dll51_x86) == true &&
                    File.Exists(Dll52_x86) == true && File.Exists(Dll53_x86) == true && File.Exists(Dll54_x86) == true &&
                    File.Exists(Dll55_x86) == true && File.Exists(Dll56_x86) == true && File.Exists(Dll57_x86) == true &&
                    File.Exists(Dll58_x86) == true && File.Exists(Dll56_x86) == true && File.Exists(Dll60_x86) == true &&
                    File.Exists(Dll61_x86) == true && File.Exists(Dll62_x86) == true && File.Exists(Dll63_x86) == true &&
                    File.Exists(Dll64_x86) == true && File.Exists(Dll65_x86) == true && File.Exists(Dll66_x86) == true &&
                    File.Exists(Dll67_x86) == true && File.Exists(Dll68_x86) == true && File.Exists(Dll69_x86) == true &&
                    File.Exists(Dll70_x86) == true && File.Exists(Dll71_x86) == true && File.Exists(Dll72_x86) == true &&
                    File.Exists(Dll73_x86) == true && File.Exists(Dll74_x86) == true && File.Exists(Dll75_x86) == true &&
                    File.Exists(Dll76_x86) == true && File.Exists(Dll77_x86) == true && File.Exists(Dll78_x86) == true &&
                    File.Exists(Dll79_x86) == true && File.Exists(Dll80_x86) == true && File.Exists(Dll81_x86) == true &&
                    File.Exists(Dll82_x86) == true && File.Exists(Dll83_x86) == true && File.Exists(Dll84_x86) == true &&
                    File.Exists(Dll85_x86) == true && File.Exists(Dll86_x86) == true && File.Exists(Dll87_x86) == true &&
                    File.Exists(Dll88_x86) == true && File.Exists(Dll89_x86) == true && File.Exists(Dll90_x86) == true &&
                    File.Exists(Dll91_x86) == true && File.Exists(Dll95_x86) &&     
                    File.Exists(Dll1_x64) == true && File.Exists(Dll2_x64) == true && File.Exists(Dll3_x64) == true &&
                    File.Exists(Dll4_x64) == true && File.Exists(Dll5_x64) == true && File.Exists(Dll6_x64) == true &&
                    File.Exists(Dll7_x64) == true && File.Exists(Dll8_x64) == true && File.Exists(Dll9_x64) == true &&
                    File.Exists(Dll10_x64) == true && File.Exists(Dll11_x64) == true && File.Exists(Dll12_x64) == true &&
                    File.Exists(Dll13_x64) == true && File.Exists(Dll14_x64) == true && File.Exists(Dll15_x64) == true &&
                    File.Exists(Dll16_x64) == true && File.Exists(Dll17_x64) == true && File.Exists(Dll18_x64) == true &&
                    File.Exists(Dll19_x64) == true && File.Exists(Dll20_x64) == true && File.Exists(Dll21_x64) == true &&
                    File.Exists(Dll22_x64) == true && File.Exists(Dll23_x64) == true && File.Exists(Dll24_x64) == true &&
                    File.Exists(Dll25_x64) == true && File.Exists(Dll26_x64) == true && File.Exists(Dll27_x64) == true &&
                    File.Exists(Dll28_x64) == true && File.Exists(Dll29_x64) == true && File.Exists(Dll30_x64) == true &&
                    File.Exists(Dll31_x64) == true && File.Exists(Dll32_x64) == true && File.Exists(Dll33_x64) == true &&
                    File.Exists(Dll34_x64) == true && File.Exists(Dll35_x64) == true && File.Exists(Dll36_x64) == true &&
                    File.Exists(Dll37_x64) == true && File.Exists(Dll38_x64) == true && File.Exists(Dll39_x64) == true &&
                    File.Exists(Dll40_x64) == true && File.Exists(Dll41_x64) == true && File.Exists(Dll42_x64) == true &&
                    File.Exists(Dll43_x64) == true && File.Exists(Dll44_x64) == true && File.Exists(Dll45_x64) == true &&
                    File.Exists(Dll46_x64) == true && File.Exists(Dll47_x64) == true && File.Exists(Dll48_x64) == true &&
                    File.Exists(Dll49_x64) == true && File.Exists(Dll50_x64) == true && File.Exists(Dll51_x64) == true &&
                    File.Exists(Dll52_x64) == true && File.Exists(Dll53_x64) == true && File.Exists(Dll54_x64) == true &&
                    File.Exists(Dll55_x64) == true && File.Exists(Dll56_x64) == true && File.Exists(Dll57_x64) == true &&
                    File.Exists(Dll58_x64) == true && File.Exists(Dll56_x64) == true && File.Exists(Dll60_x64) == true &&
                    File.Exists(Dll61_x64) == true && File.Exists(Dll62_x64) == true && File.Exists(Dll63_x64) == true &&
                    File.Exists(Dll64_x64) == true && File.Exists(Dll65_x64) == true && File.Exists(Dll66_x64) == true &&
                    File.Exists(Dll67_x64) == true && File.Exists(Dll68_x64) == true && File.Exists(Dll69_x64) == true &&
                    File.Exists(Dll70_x64) == true && File.Exists(Dll71_x64) == true && File.Exists(Dll72_x64) == true &&
                    File.Exists(Dll73_x64) == true && File.Exists(Dll74_x64) == true && File.Exists(Dll75_x64) == true &&
                    File.Exists(Dll76_x64) == true && File.Exists(Dll77_x64) == true && File.Exists(Dll78_x64) == true &&
                    File.Exists(Dll79_x64) == true && File.Exists(Dll80_x64) == true && File.Exists(Dll81_x64) == true &&
                    File.Exists(Dll82_x64) == true && File.Exists(Dll83_x64) == true && File.Exists(Dll84_x64) == true &&
                    File.Exists(Dll85_x64) == true && File.Exists(Dll86_x64) == true && File.Exists(Dll87_x64) == true &&
                    File.Exists(Dll88_x64) == true && File.Exists(Dll89_x64) == true && File.Exists(Dll90_x64) == true &&
                    File.Exists(Dll91_x64) == true && File.Exists(Dll95_x64))
                {
                    Timer_Principal.Enabled = false;
                    if (File.Exists(Application.StartupPath + "\\Dlls_x64.zip") == true)
                    {
                        File.Delete(Application.StartupPath + "\\Dlls_x64.zip");
                    }

                    if (Directory.Exists(Application.StartupPath + "\\Dlls") == true)
                    {
                        Directory.Delete(Application.StartupPath + "\\Dlls", true);
                    }
                    lb_Status.Text = "Todas Dlls Necessárias estão em seu Sistema! (x64)";
                    MessageBox.Show("Não falta nenhuma Dll em seu Sistema! (x64)\nTotal de Dlls Corrigidas:" + TotalDllCorrigidas + "\n" + XOR_Encryption(Creditos, Chave), 
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\Dlls_x64.zip") == true)
            {
                File.Delete(Application.StartupPath + "\\Dlls_x64.zip");
            }
            if (Directory.Exists(Application.StartupPath + "\\Dlls") == true)
            {
                Directory.Delete(Application.StartupPath + "\\Dlls", true);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\Dlls_x64.zip") == true)
            {
                File.Delete(Application.StartupPath + "\\Dlls_x64.zip");
            }
            if (Directory.Exists(Application.StartupPath + "\\Dlls") == true)
            {
                Directory.Delete(Application.StartupPath + "\\Dlls", true);
            }
        }

        private void clsButtonBlue1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\Dlls_x64.zip") == true)
            {
                File.Delete(Application.StartupPath + "\\Dlls_x64.zip");
            }
            if (Directory.Exists(Application.StartupPath + "\\Dlls") == true)
            {
                Directory.Delete(Application.StartupPath + "\\Dlls", true);
            }
            Application.Exit();
        }
    }
}
