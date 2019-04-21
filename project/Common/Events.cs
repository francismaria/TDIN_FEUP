using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// -- Events -- 

public delegate void UpdateActiveTablesDelegate(List<int> activeTablesIDs);

public class UpdateActiveTablesRepeater : MarshalByRefObject
{
    public event UpdateActiveTablesDelegate updateActiveTablesEvent;

    public override object InitializeLifetimeService()
    {
        return null;
    }

    public void Repeater(List<int> activeTablesIDs)
    {
        if (updateActiveTablesEvent != null)
            updateActiveTablesEvent(activeTablesIDs);
    }
}
