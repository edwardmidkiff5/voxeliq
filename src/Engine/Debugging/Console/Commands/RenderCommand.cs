﻿/*
 * Copyright (C) 2011 - 2013 Voxeliq Engine - http://www.voxeliq.org - https://github.com/raistlinthewiz/voxeliq
 *
 * This program is free software; you can redistribute it and/or modify 
 * it under the terms of the Microsoft Public License (Ms-PL).
 * 
 * Code based on: http://code.google.com/p/xnagameconsole/
 */

using System;

namespace VoxeliqEngine.Debugging.Console.Commands
{
    class RenderCommand : IConsoleCommand
    {
        public string Name
        {
            get { return "render"; }
        }

        public string Description
        {
            get { return "Renders ingame debuggers."; }
        }

        public RenderCommand()
        {
        }

        public string Execute(string[] arguments)
        {
            return String.Format("test");
        }
    }
}