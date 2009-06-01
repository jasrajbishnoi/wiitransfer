using System;
using System.Management;
using EasyWMI.Interfaces;
using EasyWMI.Models.root.CIMV2;
using EasyWMI.Controllers;
using System.Reflection;
using System.Diagnostics;
namespace EasyWMI.Controllers.root.CIMV2
{
    
    
    public class PerfRawData_Lsa_SecuritySystemWideStatistics : WMIBase, IWMIObject<Win32_PerfRawData_Lsa_SecuritySystemWideStatistics>
    {
        
        public PerfRawData_Lsa_SecuritySystemWideStatistics() : 
                base()
        {
        }
        
        public PerfRawData_Lsa_SecuritySystemWideStatistics(string ComputerName) : 
                base(ComputerName)
        {
        }
        
        public PerfRawData_Lsa_SecuritySystemWideStatistics(System.Net.IPAddress IPAddress) : 
                base(IPAddress)
        {
        }
        
        public PerfRawData_Lsa_SecuritySystemWideStatistics(string Username, string Password, string ComputerName) : 
                base(Username, Password, ComputerName)
        {
        }
        
        public PerfRawData_Lsa_SecuritySystemWideStatistics(string Username, string Password, System.Net.IPAddress IPAddress) : 
                base(Username, Password, IPAddress)
        {
        }
        
        public System.Collections.Generic.IList<Win32_PerfRawData_Lsa_SecuritySystemWideStatistics> SelectAll()
        {
            ManagementObjectCollection oReturnCollection = null;
            System.Collections.Generic.IList<Win32_PerfRawData_Lsa_SecuritySystemWideStatistics> List = new System.Collections.Generic.List<Win32_PerfRawData_Lsa_SecuritySystemWideStatistics>();
            try
            {
                oReturnCollection = GetObjectCollection("Win32_PerfRawData_Lsa_SecuritySystemWideStatistics");
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            int x = 0;
            ManagementObjectCollection.ManagementObjectEnumerator CollectionEnumerator = oReturnCollection.GetEnumerator();
            int i = 0;
            for (i = 0; (i < oReturnCollection.Count); i = (i + 1))
            {
                Win32_PerfRawData_Lsa_SecuritySystemWideStatistics WMIObject = new Win32_PerfRawData_Lsa_SecuritySystemWideStatistics();
CollectionEnumerator.MoveNext();
ManagementObject newWMIObject = (ManagementObject)CollectionEnumerator.Current;
PropertyDataCollection t = newWMIObject.Properties;
                if (t != null)
                {
PropertyDataCollection.PropertyDataEnumerator PropertyCollectionEnumerator = t.GetEnumerator();
                    for (x = 0; (x < t.Count); x = (x + 1))
                    {
PropertyInfo p = null;
PropertyData pi = null;
                        try
                        {
                            PropertyCollectionEnumerator.MoveNext();
                            pi = (PropertyData)PropertyCollectionEnumerator.Current;
                            p = typeof(Win32_PerfRawData_Lsa_SecuritySystemWideStatistics).GetProperty(pi.Name);
                        }
                        catch (System.Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                        }
                        try
                        {
                            if (p != null && pi.Value != null)
                            {
p.SetValue(WMIObject, pi.Value, null);
PropertyInfo ppath = typeof(Win32_PerfRawData_Lsa_SecuritySystemWideStatistics).GetProperty("MyPath");
ppath.SetValue(WMIObject, newWMIObject.Path.ToString(), null);
                            }
                        }
                        catch (System.Exception ex)
                        {
Debug.WriteLine(ex.Message);
                        }
                    }
                }
List.Add(WMIObject);
            }
            return List;
        }
    }
}
