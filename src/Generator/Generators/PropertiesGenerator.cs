﻿using System.Text;
using Generator.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

internal static class PropertiesGenerator
{
    public static void Generate(string outputPath, List<Class> classes)
    {
        foreach (var c in classes)
        {
            if (c.Properties.Length <= 0)
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Properties.g.cs");

            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.PropertiesHeaderTemplate);
            WriteLine(fileHeaderBuilder.ToString());

            for (var i = 0; i < c.Properties.Length; i++)
            {
                var p = c.Properties[i];

                WriteLine($"    public static {p.PropertyType} {c.Name}{p.Name} => {c.Type}.{p.Name}Property;");

                if (i < c.Properties.Length - 1)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.PropertiesFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }
}