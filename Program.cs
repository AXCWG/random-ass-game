using NAudio.Midi;
using NAudio.Wave;

namespace 文字游戏;

class Program
{
    static void Main(string[] args)
    {
        Thread 标题 = new Thread(() =>
        {
            Console.Clear();
            Thread.Sleep(100);
            Console.Write("文");
            Thread.Sleep(100);
            Console.Write("字");
            Thread.Sleep(100);
            Console.Write("游");
            Thread.Sleep(100);
            Console.WriteLine("戏");
            Thread.Sleep(500);
            Console.WriteLine("v0.1a");
            Thread.Sleep(500);
            MidiOut midiOut = new MidiOut(0);
            int channel = 1;
            int noteNumber = 50; 
            var noteOnEve = new NoteOnEvent(0, channel, noteNumber, 100, 50);
            midiOut.Send(noteOnEve.GetAsShortMessage());
            midiOut.Dispose();
        });
        标题.Start();
    }
}