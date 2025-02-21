using Rmg.PdfPrinting;
using System.IO;

if (args.Length < 2)
{
    Console.Error.WriteLine(@"Usage: PrintPdf.exe document.pdf printername
Where:
    document.pdf        File to print
    printer name        Printer to use.

Surround parameters with quotes """" if spaces in the names.
Default printer options will be used when printing.

Uses: https://github.com/mgaffigan/Rmg.PdfPrinting
License: https://mit-license.org/

Discord: .Fybre.");
    return -1;
}

try
{
    var fileToPrint = Path.GetFullPath(args[0]);
    var printerName = args[1];
    var printer = new PdfPrinter();
    await printer.Print(printerName, fileToPrint);
}
catch (Exception ex)
{
    Console.Error.WriteLine($"Error: {ex}");
    return -1;
}
return 0;