// See https://aka.ms/new-console-template for more information
// #error version
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using vocabulary;


Trace.Listeners.Add(new TextWriterTraceListener(
    File.CreateText(Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.DesktopDirectory
    ),"log.txt"))));
 Trace.AutoFlush = true;   

Trace.WriteLine("Trace says, I am watching!");
Debug.WriteLine("Debug says, I am watching!");
new Chapter04();


ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json",
        optional: true,
        reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(
    displayName: "PacktSwitch",
    description: "This swtich is set via a JSON config.");

configuration.GetSection("PacktSwitch").Bind(ts);

Trace.WriteLineIf(ts.TraceError, "Trace error");
Trace.WriteLineIf(ts.TraceWarning, "Trace Warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace Info");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");


