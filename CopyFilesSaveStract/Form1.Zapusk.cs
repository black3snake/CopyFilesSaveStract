using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CopyFilesSaveStract
{
    public partial class Form1
    {
        ParallelOptions options = new ParallelOptions();
        object locker = new object();
        static string elapsedTimeGetStatus;

        internal async Task ZapuskAsync(List<string> listSelectedFiles)
        {
            options.MaxDegreeOfParallelism = Environment.ProcessorCount > 2 ? Environment.ProcessorCount - 1 : 1;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            await Task.Run(() =>
            {
                listSelectedFiles.AsParallel().WithDegreeOfParallelism(options.MaxDegreeOfParallelism).ForAll(ls => { MyTask(ls); });
            });


            stopwatch.Stop();
            TimeSpan stopwatchElapsed = stopwatch.Elapsed;
            var milsec = Convert.ToInt32(stopwatchElapsed.TotalMilliseconds);
            var sec = milsec / 1000;
            var ts = TimeSpan.FromSeconds(sec);

            elapsedTimeGetStatus = $"{ts.Hours}ч:{ts.Minutes}м:{ts.Seconds}с";
            labTime.Text = $"{ts.Hours}ч:{ts.Minutes}м:{ts.Seconds}с";
            //logger.Info($"Затраченное время: {ts.Hours}ч:{ts.Minutes}м:{ts.Seconds}с");

        }

        internal void MyTask(object arg)
        {
            string fn = (string)arg;
            DataFiles dFile;
            if (!labDirTargetName.Text.Contains("__________") & !string.IsNullOrEmpty(labDirTargetName.Text))
            {
                dFile = new DataFiles(labDirTargetName.Text, labDirSrcName.Text, fn);
            } else
            {
                dFile = null;
            }

            if(dFile != null)
                dFile.FileCopy();


            lock (locker)
            {
                Invoke(new Action(() =>
                {
                    ConsoleTB.AppendText($"файл {dFile.GetLengthFileName()} скопирован: {dFile.fileNewName}" + Environment.NewLine);
                }));
            }

        }
    }
}