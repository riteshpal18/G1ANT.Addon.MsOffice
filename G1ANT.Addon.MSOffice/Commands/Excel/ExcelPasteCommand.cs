﻿/**
*    Copyright(C) G1ANT Ltd, All rights reserved
*    Solution G1ANT.Addon, Project G1ANT.Addon.MSOffice
*    www.g1ant.com
*
*    Licensed under the G1ANT license.
*    See License.txt file in the project root for full license information.
*
*/

using System;
using System.Linq;
using G1ANT.Language;

namespace G1ANT.Addon.MSOffice
{
    [Command(Name = "excel.paste", Tooltip = "This command inserts clipboard content into the currently selected cell or range")]
    public class ExcelPasteCommand : Command
    {
        public ExcelPasteCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(CommandArguments arguments)
        {
            try
            {
                ExcelManager.CurrentExcel.Paste();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occurred while trying to paste. Message: {ex.Message}", ex);
            }
        }
    }
}
