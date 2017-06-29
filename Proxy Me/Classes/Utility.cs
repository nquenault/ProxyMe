using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

static class Utility
{
    public static void ParallelWhile(Func<bool> condition, Action body, int? MaxDegreeOfParallelism = null)
    {
        ParallelOptions opts = new ParallelOptions();

        if (MaxDegreeOfParallelism.HasValue)
            opts.MaxDegreeOfParallelism = MaxDegreeOfParallelism.Value;

        System.Threading.Tasks.Parallel.ForEach(IterateUntilFalse(condition), opts, ignored => body());
    }

    private static IEnumerable<bool> IterateUntilFalse(Func<bool> condition)
    {
        while (condition()) yield return true;
    }

    private static class Generator
    {
        private static readonly Random _random = new Random();
        public static int Rand(int max = 100, int min = 0) { return _random.Next(min, max + 1); }
        public static double Rand(double max = 100, double min = 0, bool round = true) { double v = _random.NextDouble() * (max - min) + min; return round ? Math.Round(v) : v; }
        public static bool RandPourcentage(double pourcentage)
        {
            double p = Rand((double)100);
            return pourcentage >= p;
        }
    }
    public static int Rand(int max = 100, int min = 0) { return Generator.Rand(max, min); }
    public static double Rand(double max = 100, double min = 0, bool round = true) { return Generator.Rand(max, min, round); }
    public static bool RandPourcentage(double pourcentage) { return Generator.RandPourcentage(pourcentage); }
    public static T Rand<T>(IEnumerable<T> items)
    {
        return items.ElementAt(Utility.Rand(items.Count() - 1, 0));
    }

    public static void TryInvoke(Control control, Delegate method)
    {
        try
        {
            if (control == null) return;
            else if (control.InvokeRequired)
                control.Invoke(method);
            else
                method.DynamicInvoke();
        }
        catch { }
    }
}

