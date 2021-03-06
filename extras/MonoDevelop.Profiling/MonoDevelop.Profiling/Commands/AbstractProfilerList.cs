//
// Authors:
//   Ben Motmans  <ben.motmans@gmail.com>
//
// Copyright (C) 2007 Ben Motmans
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
using MonoDevelop.Core;
using MonoDevelop.Core.Execution;
using MonoDevelop.Components;
using MonoDevelop.Ide;
using MonoDevelop.Components.Commands;

namespace MonoDevelop.Profiling
{
	internal class AbstractProfilerList : CommandHandler
	{
		protected override void Update (CommandArrayInfo info)
		{
			if (ProfilingService.ProfilerCount > 0) {
				foreach (IProfiler prof in ProfilingService.Profilers) {
					CommandInfo cmd = new CommandInfo (GettextCatalog.GetString (prof.Name));
					cmd.UseMarkup = true;
					cmd.Icon = prof.IconString;
					if (prof.IsSupported) {
						if (IdeApp.Workspace.IsOpen)
							cmd.Enabled = IdeApp.ProjectOperations.CurrentRunOperation.IsCompleted;
						else
							cmd.Enabled = (IdeApp.Workbench.ActiveDocument != null && IdeApp.Workbench.ActiveDocument.IsBuildTarget);
					} else {
						cmd.Enabled = false;
					}
					
					info.Add (cmd, prof);
				}
			} else {
				CommandInfo cmd = new CommandInfo (GettextCatalog.GetString ("No profilers detected."));
				cmd.Enabled = false;
				info.Add (cmd, null);
			}
		}		
	}
}