namespace EdibleFungusGreenhouse.Common
{
    public static class Global
    {
        /// <summary>
        /// 界面跳转委托
        /// </summary>
        public delegate void DgOnSkipPage(string pageName);
        public static DgOnSkipPage gOnSkipPage;
    }
}
