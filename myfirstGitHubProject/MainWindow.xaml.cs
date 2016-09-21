using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace myfirstGitHubProject
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Set3D(Str);

        }

        private const byte ShowItemCount = 10;
        private double AddAngle = 1;
        private double StartPosition = 0;
        private double AngleOffset = 0;
        private string ItemCount = "0";
        private int ItemCountInt = 0;
        private int SelectItemIndex = 0;
        private int SelectImage = 0;
        private String[] Str = new string[] { "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/f40bba2d-9140-435b-83c6-413a55b96efa_5.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/ad31d4e4-9a77-491d-bbc5-fd438f336edc_5.jpg", "http://res1.windows.microsoft.com/resbox/en/Windows%207/main/6854b05f-833a-4691-9ca3-bf4f51dc278c_5.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/e8e3b869-1645-4895-aac1-8c9bcdfeec8e_5.jpg", "http://res1.windows.microsoft.com/resbox/en/Windows%207/main/5eeb3265-d6ed-4281-b58c-2f319cd3b6d0_5.jpg", "http://res1.windows.microsoft.com/resbox/en/Windows%207/main/2217470a-9d69-4f14-82a6-0a2ef83cf949_5.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/893b4f22-1b55-4c5e-8e11-92dc9e01faa9_5.jpg", "http://res1.windows.microsoft.com/resbox/en/Windows%207/main/0013aba9-acea-440a-95cc-2e6518eaee4e_5.jpg", "http://res1.windows.microsoft.com/resbox/en/Windows%207/main/8faccb7b-a2f3-4ac5-a2b2-1d1dada132e5_5.jpg", "http://res1.windows.microsoft.com/resbox/en/Windows%207/main/55077d99-fd10-4412-b4a8-87c31c26b359_11.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/30f904c9-8690-4824-87b2-58feb9e9a78d_12.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/2328b466-1ce4-43df-9b61-ebac18eeea28_5.jpg", "http://res1.windows.microsoft.com/resbox/en/Windows%207/main/85b037e7-d349-44be-893e-3cd4d9e63536_5.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/c7babeac-d978-4b94-9b70-020161cde4b9_11.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/f9408efe-5ad2-485a-a3bf-bdb005468911_5.jpg", "http://res1.windows.microsoft.com/resbox/en/Windows%207/main/c2770d31-d0b6-48fb-9325-d1dc99b90171_9.jpg", "http://res1.windows.microsoft.com/resbox/en/Windows%207/main/4dcd542e-7cfe-4696-9751-d9fdf381ea6b_5.jpg", "http://res1.windows.microsoft.com/resbox/en/Windows%207/main/3a6fc8dd-0eaa-4a1f-8357-79d816c3fee4_5.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/8ac6cfb8-86cb-4c02-b7b7-537281a5da90_5.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/b8ffcb5b-8211-411b-bd3a-ec1a24ec1fdb_5.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/40f24f2e-f3d7-4ddc-aacd-8003a84863cb_9.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/a1a9c343-5838-4c91-925e-5abd3dad47d1_9.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/ceca23f8-9e8f-4b41-8b4c-30c7d499f4ff_13.jpg", "http://res1.windows.microsoft.com/resbox/en/Windows%207/main/2573cef4-938e-45f9-8905-b2e7364e62c7_9.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/e0150d9d-d616-4de2-9e15-c893171351d1_13.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/47754a3e-6938-48e2-ae2e-abb590101660_5.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/743c9e99-4dcd-4fb5-8ff2-ee5ef894d5bd_5.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/78ac4832-7eb6-4153-9c30-a9b03cb900c3_5.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/827f6e76-0f21-4f7c-9471-d34a52d9d842_5.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/af0f3abd-1fed-49ce-b4a0-5890b0cb5dec_5.jpg", "http://res1.windows.microsoft.com/resbox/en/Windows%207/main/1de726dd-d8f7-46f4-a1bc-e14d011e0772_5.jpg", "http://res2.windows.microsoft.com/resbox/en/Windows%207/main/0757bcd8-4b73-459a-9742-d72b1faadfca_5.jpg" };
        private void Control_MouseMove(System.Object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                SetControlAngle(e.GetPosition(this).X - StartPosition, 1);
                StartPosition = e.GetPosition(this).X;
            }
        }
        private void Control_MouseLeftButtonDown(System.Object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            StartPosition = e.GetPosition(this).X;
        }
        private void Control_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            SetControlAngle(0 - e.Delta, 5);
        }
        private void SetControlAngle(double i, int j)
        {
            if (i < 0)
            {
                ControlAngle.Angle = ControlAngle.Angle + AddAngle * j;
            }
            else
            {
                if (i > 0)
                {
                    ControlAngle.Angle = ControlAngle.Angle - AddAngle * j;
                }
            }
            if (ControlAngle.Angle < 0)
            {
                ControlAngle.Angle = 360;
            }
            else
            {
                if (ControlAngle.Angle > 360)
                {
                    ControlAngle.Angle = 0;
                }
            }
            SelectItemIndex = (int)Math.Round((ControlAngle.Angle / AngleOffset), 0);
            if (SelectItemIndex > ItemCountInt)
            {
                SelectItemIndex = ItemCountInt;
            }
            //   Txt.Text = (SelectItemIndex + 1).ToString() + ItemCount;
        }
        private void Set3D(string[] Items)
        {
            try
            {
                ControlAngle.Angle = 0;
                ItemCountInt = Items.Length - 1;
                ItemCount = " / " + Items.Length.ToString();
                //  Txt.Text = "1" + ItemCount;
                SelectItemIndex = 0;
                SelectImage = 0;
                AngleOffset = 360.0 / Items.Length;
                double ItemAngle = AngleOffset * Math.PI / 180;
                int OneSideCount = (int)Math.Floor(Items.Length / 4.0);
                int VisualWidth = OneSideCount * 35;
                double StartAngle = 0;
                MV.Children.Clear();
                foreach (String Item in Items)
                {
                    ModelVisual3D MV3D = new ModelVisual3D { Transform = new TranslateTransform3D(Math.Sin(StartAngle) * VisualWidth, 0, Math.Cos(StartAngle) * VisualWidth) };
                    ModelVisual3D MV3DContent = new ModelVisual3D { Content = (Model3DGroup)this.Resources["M3DG"], Transform = (Transform3D)this.Resources["RT"] };
                    BitmapImage Img = new BitmapImage(new Uri(Item));

                    MV3DContent.Children.Add(new Viewport2DVisual3D { Geometry = (MeshGeometry3D)this.Resources["MG1"], Material = (Material)this.Resources["DM"], Visual = new Button { Tag = Img, Style = (Style)this.Resources["Btn"] } });
                    MV3DContent.Children.Add(new Viewport2DVisual3D { Geometry = (MeshGeometry3D)this.Resources["MG2"], Material = (Material)this.Resources["DM"], Visual = new Border { Style = (Style)this.Resources["Bdr"], Child = new Border { Child = new Image { Stretch = Stretch.Fill, Source = Img }, Width = 70, Height = 70, VerticalAlignment = VerticalAlignment.Bottom } } });
                    MV3D.Children.Add(MV3DContent);
                    MV.Children.Add(MV3D);
                    StartAngle = StartAngle + ItemAngle;
                }
                int ShowItemCountTemp = ShowItemCount;
                if (ShowItemCount > OneSideCount)
                {
                    ShowItemCountTemp = OneSideCount;
                }
                double AngleTemp = ItemAngle * ShowItemCountTemp;
                double Temp = (1 - Math.Cos(AngleTemp)) * VisualWidth;
                PC.FarPlaneDistance = 150 + Temp;
                PC.Position = new Point3D(0, 0, 150 + VisualWidth);
                PC.FieldOfView = Math.Atan(Math.Sin(AngleTemp) * (VisualWidth + 250) / PC.FarPlaneDistance) * 360 / Math.PI;
                AddAngle = 360.0 / Items.Length / 30.0;
                L1.Position = new Point3D(PC.Position.X - 100, PC.Position.Y + 100, PC.Position.Z);
                L1.Direction = new Vector3D(0 - L1.Position.X, 0 - L1.Position.Y, 0 - L1.Position.Z);
                L1.OuterConeAngle = PC.FieldOfView;
                L2.Position = new Point3D(PC.Position.X + 100, L1.Position.Y, L1.Position.Z);
                L2.Direction = new Vector3D(0 - L2.Position.X, L1.Direction.Y, L1.Direction.Z);
                L2.OuterConeAngle = PC.FieldOfView;
            }
            catch { }
        }
        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog OpenFileSel = new Microsoft.Win32.OpenFileDialog
                {
                    Title = "Select Images",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Multiselect = true,
                    ValidateNames = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = false,
                    RestoreDirectory = true,
                    DereferenceLinks = true,
                    Filter = "Image|*.BMP;*.DIB;*.PNG;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.ICO;*.WMF;*.EMF;*.JPS;*.PNS;*.MPO;*.WDP;*.RLE;*.CGM;*.PCT|All|*.*",
                    FilterIndex = 1
                };
                if (OpenFileSel.ShowDialog() == true && OpenFileSel.FileNames.Length > 0)
                {
                    Str = OpenFileSel.FileNames;
                    Set3D(Str);
                }
            }
            catch { }
        }
        private void BtnImage_Click(object sender, RoutedEventArgs e)
        {
            SelectImage = SelectItemIndex;
            ImgGrid.Visibility = System.Windows.Visibility.Visible;
            ImgViewer.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(Str[SelectItemIndex]));
        }
        private void BtnViewer_Click(object sender, RoutedEventArgs e)
        {
            ImgGrid.Visibility = System.Windows.Visibility.Collapsed;
            ImgViewer.Source = null;
        }
        private void Image_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                SelectImage = SelectImage + 1;
                if (SelectImage >= Str.Length)
                {
                    SelectImage = 0;
                }
            }
            else
            {
                if (e.Delta < 0)
                {
                    SelectImage = SelectImage - 1;
                    if (SelectImage < 0)
                    {
                        SelectImage = Str.Length - 1;
                    }
                }
            }
            ImgViewer.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(Str[SelectImage]));
        }


    }
}
