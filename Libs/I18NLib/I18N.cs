namespace I18NLib
{
    public class I18N
    {
        #region Singleton
        private static I18N? Instance;
        private static readonly object Locker = new();
        public static I18N GetInstance()
        {
            lock (Locker)
                Instance ??= new I18N();

            return Instance;
        }
        private I18N() { }
        #endregion

        private ILanguage? Language { get; set; }
        private ELanguage? LanguageType { get; set; }

        /// <summary>
        /// Setting type of language to be used.
        /// </summary>
        /// <param name="language">Language type.</param>
        public void SetLanguage(ELanguage language)
        {
            LanguageType = language;
        }
        /// <summary>
        /// Get language instance.
        /// </summary>
        /// <returns></returns>
        public ILanguage GetLanguage()
        {
            Language ??= LanguageType switch
                {
                    ELanguage.ENGLISH => new English(),
                    ELanguage.CHINESE => new Chinese(),
                    _ => new Chinese(),
                };

            return Language;
        }
    }

    public enum ELanguage
    {
        CHINESE = 0,
        ENGLISH
    }
}