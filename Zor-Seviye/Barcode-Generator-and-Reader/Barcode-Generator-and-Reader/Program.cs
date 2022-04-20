using BarcodeLib;
using BarcodeLib.BarcodeReader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

BarcodeCreate("869412244212");
BarcodeRead();


void BarcodeCreate(string NumericString)
{
    Barcode barcodLib = new Barcode();

    int imageWidth = 290; 
    int imageHeight = 120; 
    Color foreColor = Color.Black; 
    Color backColor = Color.White; 

    Image barcodeImage = barcodLib.Encode
        (TYPE.UPCA, NumericString, foreColor, backColor, imageWidth, imageHeight);

    barcodeImage.Save(@"D:\Barcode.png", ImageFormat.Png);
}
void BarcodeRead()
{
    string[] BarcodeUPCA = BarcodeReader.read(@"D:\Barcode.png",
        BarcodeReader.UPCA);

    StringBuilder builder = new StringBuilder();
    foreach (string value in BarcodeUPCA)
    {
        builder.Append(value);
        Console.WriteLine(value);
    }
    //Console.WriteLine("UPCA Code:" + builder.ToString());
}