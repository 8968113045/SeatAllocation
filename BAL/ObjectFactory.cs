using AppFramework;
using BAL;
using System;
namespace BAL
{
    public class ObjectFactory
    {
        public static IUserInterface GetUIObject(int roundno)
        {
            return new ComCouns21UI();            
        }

        public static IValidation GetValidationObject(int roundno)
        {
            return new ComCouns21Validation();
        }


        public static IAllocation GetAllocationObject(int roundno)
        {
            return new ComCouns21Allocation();
        }


        public static IDownload GetDownloadObject(int roundno)
        {
            return new ComCouns21Download();
        }

        public static ICommon GetCommonObject()
        {
            return new DefaultCommon();
        }

    }
}
