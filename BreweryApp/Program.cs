// See https://aka.ms/new-console-template for more information
using BreweryApp;
using System.Diagnostics;

TraceSource TRACE = new TraceSource("Brewery");
TRACE.Listeners.Add(
    new TextWriterTraceListener(
        new StreamWriter(@"M:\pub\Brewery.txt")));
TRACE.Listeners.Add(new ConsoleTraceListener());


TRACE.Switch = new SourceSwitch("Brewery", "all");

BreweryWorker worker = new BreweryWorker(TRACE);
worker.Start();

Console.WriteLine("Simulation finished - look in logfile");
Console.ReadLine();
