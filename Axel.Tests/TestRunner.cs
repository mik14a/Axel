/*
 * Copyright © 2017 mik14a <mik14a@gmail.com>
 * This work is free. You can redistribute it and/or modify it under the
 * terms of the Do What The Fuck You Want To Public License, Version 2,
 * as published by Sam Hocevar. See the COPYING file for more details.
 */

using System.Reflection;

namespace Axel
{
    class TestRunner : Microsoft.VisualStudio.TestTools.UnitTesting.TestRunner
    {
        static void Main(string[] args) {
            var program = new TestRunner();
            program.Run(Assembly.GetEntryAssembly());
        }
    }
}
