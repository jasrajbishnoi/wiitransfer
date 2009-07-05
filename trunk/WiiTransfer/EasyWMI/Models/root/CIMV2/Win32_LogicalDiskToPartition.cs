using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_LogicalDiskToPartition : WMIBase
    {
        
        private string m_Antecedent;
        
        private string m_Dependent;
        
        private ulong m_EndingAddress;
        
        private ulong m_StartingAddress;
        
        private string m_MyPath;
        
        public Win32_LogicalDiskToPartition()
        {
        }
        
        public string Antecedent
        {
            get
            {
                return this.m_Antecedent;
            }
            set
            {
                this.m_Antecedent = value;
            }
        }
        
        public string Dependent
        {
            get
            {
                return this.m_Dependent;
            }
            set
            {
                this.m_Dependent = value;
            }
        }
        
        public ulong EndingAddress
        {
            get
            {
                return this.m_EndingAddress;
            }
            set
            {
                this.m_EndingAddress = value;
            }
        }
        
        public ulong StartingAddress
        {
            get
            {
                return this.m_StartingAddress;
            }
            set
            {
                this.m_StartingAddress = value;
            }
        }
        
        public string MyPath
        {
            get
            {
                return this.m_MyPath;
            }
            set
            {
                this.m_MyPath = value;
            }
        }
    }
}