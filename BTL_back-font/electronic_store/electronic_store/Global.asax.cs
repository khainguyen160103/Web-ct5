using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace electronic_store
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            List<Objects.products> listProduct_DD = new List<Objects.products>();
            listProduct_DD.Add(new Objects.products("DD1", "INSE-P20-5-in-1-Dog-Clipper-Vacuum-521459-0._w280_", "", 85, 107, 199));
            listProduct_DD.Add(new Objects.products("DD2", "Outdoor-Sports-Fanny-Pack-522193-0._w280_", "", 89, 105, 198));
            listProduct_DD.Add(new Objects.products("DD3", "FOSSiBOT-F2400-2048Wh-Portable-Power-Station-Black-UK-Plug-523374-7._w280_", "", 4.62, 8.68, 187));
            listProduct_DD.Add(new Objects.products("DD4", "ouvis-amr5-mini-pc--amd-ryzen-7-5700u-eu-bdc6e3-1695107508087._w280_", "", 255, 324, 190));
            listProduct_DD.Add(new Objects.products("DD5", "ESSAGER-EXCMTL-JJ03-P-100W-3-in-1-USB-Data-Cable-Black-523797-0._w280_", "", 5.28, 14.61, 100));
            listProduct_DD.Add(new Objects.products("DD6", "duotts-c29-electric-bike-29-inch-750w-48v-15ah-50km-h-with-rear-rack-289d6b-1709806782169._w280_", "", 755, 903, 199));
            Application["listProductDD"] = listProduct_DD;


            List<Objects.products> ListProduct_New = new List<Objects.products>();
            ListProduct_New.Add(new Objects.products("N1", "ESSAGER-30W-USB-A-Type-C-Car-Charger-Black-523839-0._w280_p1_", "ESSAGER 30W Car Charger, USB-A+Type-C Dual Ports, PD Fast", 0, 8.11, 0));
            ListProduct_New.Add(new Objects.products("N2", "HAYEA-Microscope-Camera-523597-0._w280_p1_", "HAYEA Microscope Camera, 8MP 4K Transparent Electrolic Eyepiece, USB", 0, 116.09, 0));
            ListProduct_New.Add(new Objects.products("N3", "TANIX-TX1-Mini-TV-Box-523290-0._w280_p1_", "TANIX TX1 Mini TV Box, Android 10, Allwinner H313, Built-in WiFi, 2GB", 0, 17.59, 0));
            ListProduct_New.Add(new Objects.products("N4", "USB-Wireless-Adapter-Bluetooth-5-4-524082-0._w280_p1_", "USB Wireless Adapter Bluetooth 5.4", 0, 4.14, 0));
            Application["listProductN"] = ListProduct_New;

            List<Objects.products> ListProduct_BSL = new List<Objects.products>();
            ListProduct_BSL.Add(new Objects.products("BS1", "anbernic-rg35xx-handheld-game-console-64-128gb-card-grey-83eb49-1679041274101._w280_p1_", "ANBERNIC RG35XX Handheld Game Console 3.5-inch IPS Full", 48.71, 64.59, 501));
            ListProduct_BSL.Add(new Objects.products("BS2", "H96-MAX-V58-Android-12-RK3588-8GB-64GB-TV-BOX-8K-decode-517022-0._w280_p1_", "H96 MAX V58 Android 12 TV Box RK3588 Octa Core 2.4GH", 146.13, 172.11, 6));
            ListProduct_BSL.Add(new Objects.products("BS3", "rg351p-anbernic-retro-game-console-black-7878ca-1680171556702._w280_p1_", "ANBERNIC RG351P 64GB Retro Game Console - Black", 64.94, 89.30, 266));
            ListProduct_BSL.Add(new Objects.products("BS4", "zll-sg907-max-4k-gps-rc-drone-two-batteries-with-bag-1616464707119._w280_p1_", "ZLL SG907 MAX 4K 5G WIFI FPV GPS Foldable RC Drone", 154.27, 162.39, 6));
            ListProduct_BSL.Add(new Objects.products("BS5", "tronsmart-element-mega-bluetooth-speaker-black-1571991584812._w280_p1_", "Tronsmart Element Mega SoundPulse™ Bluetooth 5.0 Speaker", 35.76, 54.46, 948));
            Application["ListProduct_BSL"] = ListProduct_BSL;

            List<Objects.products> listProduct_PB = new List<Objects.products>();
            listProduct_PB.Add(new Objects.products("PB1", "INSE-P20-5-in-1-Dog-Clipper-Vacuum-521459-0._w280_", "", 85, 107, 199));
            listProduct_PB.Add(new Objects.products("PB2", "Outdoor-Sports-Fanny-Pack-522193-0._w280_", "", 89, 105, 198));
            listProduct_PB.Add(new Objects.products("PB3", "FOSSiBOT-F2400-2048Wh-Portable-Power-Station-Black-UK-Plug-523374-7._w280_", "", 4.62, 8.68, 187));
            listProduct_PB.Add(new Objects.products("PB4", "ouvis-amr5-mini-pc--amd-ryzen-7-5700u-eu-bdc6e3-1695107508087._w280_", "", 255, 324, 190));
            listProduct_PB.Add(new Objects.products("DD5", "ESSAGER-EXCMTL-JJ03-P-100W-3-in-1-USB-Data-Cable-Black-523797-0._w280_", "", 5.28, 14.61, 100));
            listProduct_PB.Add(new Objects.products("DD6", "duotts-c29-electric-bike-29-inch-750w-48v-15ah-50km-h-with-rear-rack-289d6b-1709806782169._w280_", "", 755, 903, 199));
            listProduct_PB.Add(new Objects.products("DD1", "INSE-P20-5-in-1-Dog-Clipper-Vacuum-521459-0._w280_", "", 85, 107, 199));
            listProduct_PB.Add(new Objects.products("DD2", "Outdoor-Sports-Fanny-Pack-522193-0._w280_", "", 89, 105, 198));
            listProduct_PB.Add(new Objects.products("DD3", "FOSSiBOT-F2400-2048Wh-Portable-Power-Station-Black-UK-Plug-523374-7._w280_", "", 4.62, 8.68, 187));
            listProduct_PB.Add(new Objects.products("DD4", "ouvis-amr5-mini-pc--amd-ryzen-7-5700u-eu-bdc6e3-1695107508087._w280_", "", 255, 324, 190));
            listProduct_PB.Add(new Objects.products("DD5", "ESSAGER-EXCMTL-JJ03-P-100W-3-in-1-USB-Data-Cable-Black-523797-0._w280_", "", 5.28, 14.61, 100));
            listProduct_PB.Add(new Objects.products("DD6", "duotts-c29-electric-bike-29-inch-750w-48v-15ah-50km-h-with-rear-rack-289d6b-1709806782169._w280_", "", 755, 903, 199));
            Application["listProduct_PB"] = listProduct_PB;


        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}