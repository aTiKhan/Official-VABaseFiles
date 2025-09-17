/********************************************************
 * Project Name   : VAdvantage
 * Class Name     : AlertEventMgr
 * Purpose        : 
 * Chronological    Development
 * Raghunandan      06-May-2009 
  ******************************************************/

using System.Collections.Generic;
using VAdvantage.Model;


namespace VAdvantage.Alert
{
    public interface AlertEventMgr
    {

        /// <summary>
        ///Process alert event Value 
        /// </summary>
        /// <param name="document">document</param>
        /// <param name="AD_Table_ID">table</param>
        /// <returns> true if WF started</returns>
        bool Process(bool newRecord, PO document, int AD_Table_ID,List<(int ColumnId, string ColumnName)> columnIds, bool isDeleted);
    }
}
