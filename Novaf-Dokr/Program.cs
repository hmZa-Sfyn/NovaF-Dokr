﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Diagnostics;
using System.Collections;

using nova.Utils;
using nova.Command;
using nova.Command.env;
using System.Runtime.ExceptionServices;
using System.Reflection.Metadata.Ecma335;
using Novaf_Dokr.Customization.configuration;
using Novaf_Dokr.Customization;
using System.Diagnostics.SymbolStore;
using Novaf_Dokr.Customization.lang.xMake;
//using nova.Tests;

namespace novaf
{
    public class Program
    {
        public static string __version__ = "1.4.9";
        static void Main(string[] args)
        {
            //Console.WriteLine("(c) nova Initial Developers | Fri3nds .G");
            DesignFormat.Banner();

            Initnova(false);
        }

        public static void Initnova(bool isctrlc)
        {
            #region UnitTests
            //UnitTests.Test1();
            //UnitTests.Test2();
            //UnitTests.Test3();
            //UnitTests.Test4();
            //UnitTests.Test_RunCmd();

            //nova.Command.env.Vars.main_test();
            //UnitTests.Test_Exit();
            #endregion

            #region shall tests
            //abc:
            //List<string> parts= new List<string>();
            //parts = ["@bin","ls","--path", "$(BinPath)"];
            //for (int i = 0; i < parts.Count; i++)
            //{
            //    if (parts[i].StartsWith("$("))
            //    {
            //        parts[i] = parts[i].Replace("$(", "");
            //        parts[i] = parts[i].Replace(")", "");

            //        Console.WriteLine($":: {parts[i]}");
            //    }
            //    else
            //    {

            //    }
            //}
            //Console.ReadLine();
            //goto abc;
            #endregion

            //RunOnWindows.RunPythonFile(["C:\\Users\\Hamza\\vin_env\\ibin\\python\\usmnh\\tabl.py"]);
            //Environment.Exit(0);

            //{
            //    List<string> commands = UserInput.Prepare("@sudev do run d:G:\\fri3nds\\v-category-projects\\Developer-Grade-Virtual-OS\\Ju-hind-F\\Ju-Hind-F\\Ju-Hind-F\\Command\\env\\doker_lang\\test.dokr");

            //    IdentifyCommand.Identify(commands);
            //    List<string> parsed_commands = IdentifyCommand.ReturnThemPlease();

            //    PleaseCommandEnv.TheseCommands(parsed_commands);

            //    IdentifyCommand.CacheClean();

            //    Environment.Exit(0);
            //}

            //{
            //    nova_vm.Command.env.doker_lang.Interpreter.Interpret.Helper.ThisCode();


            //    Environment.Exit(0);

            //}

            #region Actual Init

            CommandEnv.LoadEnvironmentPointers();
            CommandEnv.LoadEnvironmentVariables();

            master.conf.EnsureEnvironmentSetup();

            //foreach (master.conf.ConfigurationData _cd in master._Conf_Files_List)
            //{
            //    Console.WriteLine(_cd.File.Path.ToString());
            //}


            try
            {
                while (true)
                {
                    _entry_point_main:
                    try
                    {
                        // Handle CTRL+C key press to prevent quitting
                        Console.CancelKeyPress += (sender, e) =>
                        {
                            e.Cancel = false; // Prevent the app from closing
                            Console.WriteLine("\nTolerating CTRL+C!");
                            Console.ForegroundColor = XmInterpreter.__CurrentForegroundColor;
                            Console.BackgroundColor = XmInterpreter.__CurrentBackgroundColor;
                            Initnova(true);
                        };

                        if (!isctrlc)
                        {
                            // The rest of your code
                            DesignFormat.TakeInput([$"\n{CommandEnv.CURRENT_USER_NAME}", "@", "kernal", "::", $"{CommandEnv.CurrentDirDest}", " % "]);
                            List<string> commands = UserInput.Prepare(UserInput.Input());
                            IdentifyCommand.Identify(commands);
                            List<string> parsed_commands = IdentifyCommand.ReturnThemPlease();
                            PleaseCommandEnv.TheseCommands(parsed_commands);
                            IdentifyCommand.CacheClean();
                        }
                        else
                        { 
                            isctrlc = false;
                        }

                        continue;

                    }
                    catch (Exception exp) // Exception handling block
                    {
                        errs.CacheClean();
                        errs.New(exp.ToString());
                        errs.ListThem();
                    }

                    // Handle CTRL+C key press to prevent quitting
                    Console.CancelKeyPress += (sender, e) =>
                    {
                        e.Cancel = false; // Prevent the app from closing
                        //Console.WriteLine("\nTolerating CTRL+C!");
                    };
                }
            }
            catch (Exception exx)
            {
                errs.New(exx.ToString());
                errs.ListThem();
                errs.CacheClean();
            }

            // Handle CTRL+C key press to prevent quitting
            Console.CancelKeyPress += (sender, e) =>
            {
                e.Cancel = true; // Prevent the app from closing
                Console.WriteLine("\nTolerating CTRL+C!");
            };
        }
        #endregion
    }
}