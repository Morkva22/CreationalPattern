using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Builder
{
    public class Director
    {
        private IBuilder<string> _builder;
        
        public Director(IBuilder<string> builder)
        {
            _builder = builder;
        }
        
        public void BuildMinimalPC()
        {
            _builder.InstallCPU();
            _builder.InstallRAM();
            _builder.InstallStorage();
            _builder.InstallPowerSupply();
        }
        
        public void BuildGamingPC()
        {
            _builder.InstallCPU();
            _builder.InstallRAM();
            _builder.InstallGPU();
            _builder.InstallStorage();
            _builder.InstallPowerSupply();
            _builder.InstallCooling();
        }
        
        public void BuildOfficePC()
        {
            _builder.InstallCPU();
            _builder.InstallRAM();
            _builder.InstallGPU();
            _builder.InstallStorage();
            _builder.InstallPowerSupply();
        }
        
        public void DisassembleGamingPC()
        {
            _builder.RemoveCPU();
            _builder.RemoveRAM();
            _builder.RemoveGPU();
            _builder.RemoveStorage();
            _builder.RemovePowerSupply();
            _builder.RemoveCooling();
        }
        
        public void DisassembleMinimalPC()
        {
            _builder.RemoveCPU();
            _builder.RemoveRAM();
            _builder.RemoveStorage();
            _builder.RemovePowerSupply();
        }
        
        public void DisassembleOfficePC()
        {
            _builder.RemoveCPU();
            _builder.RemoveRAM();
            _builder.RemoveGPU();
            _builder.RemoveStorage();
            _builder.RemovePowerSupply();
        }
    }
}