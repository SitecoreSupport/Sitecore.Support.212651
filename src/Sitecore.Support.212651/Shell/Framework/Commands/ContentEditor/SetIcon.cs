using Sitecore.Shell.Framework.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Shell.Framework.Commands.ContentEditor
{
	public class SetIcon : Sitecore.Shell.Framework.Commands.ContentEditor.SetIcon
	{
		public override string GetIcon(CommandContext context, string defaultValue)
		{
			if (this.QueryState(context) == CommandState.Disabled)
			{
				return "Custom/16x16/error.png";
			}
			if (context.Items.Length == 1)
			{
				return context.Items[0].Appearance.Icon;
			}
			return base.GetIcon(context, defaultValue);
		}
	}
}