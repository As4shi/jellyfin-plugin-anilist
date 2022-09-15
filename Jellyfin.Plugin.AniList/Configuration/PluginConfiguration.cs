using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.AniList.Configuration
{
    public enum TitlePreferenceType
    {
        /// <summary>
        /// Use titles in the local metadata language.
        /// </summary>
        Localized,

        /// <summary>
        /// Use titles in JapanesePeople.
        /// </summary>
        Japanese,

        /// <summary>
        /// Use titles in JapanesePeople romaji.
        /// </summary>
        JapaneseRomaji
    }
    public enum PeoplePreferenceType
    {
        /// <summary>
        /// Only include JapanesePeople people. Might cause some issues with Korean/Chinese shows.
        /// </summary>
        JapanesePeople,

        /// <summary>
        /// Only show people that are not JapanesePeople. Might cause issues with animes that don't have any dubs.
        /// </summary>
        NonJapanesePeople,
        /// <summary>
        /// Include all people available.
        /// </summary>
        AllPeople
    }

    public enum AnimeDefaultGenreType
    {
        None, Anime, Animation
    }

    public class PluginConfiguration : BasePluginConfiguration
    {
        public PluginConfiguration()
        {
            TitlePreference = TitlePreferenceType.Localized;
            OriginalTitlePreference = TitlePreferenceType.JapaneseRomaji;
            PeoplePreference = PeoplePreferenceType.JapanesePeople;
            MaxGenres = 5;
            AnimeDefaultGenre = AnimeDefaultGenreType.Anime;
            AniDbRateLimit = 2000;
            AniDbReplaceGraves = true;
            AniListShowSpoilerTags = true;
        }

        public TitlePreferenceType TitlePreference { get; set; }

        public TitlePreferenceType OriginalTitlePreference { get; set; }
        public PeoplePreferenceType PeoplePreference { get; set; }

        public int MaxGenres { get; set; }

        public AnimeDefaultGenreType AnimeDefaultGenre { get; set; }

        public int AniDbRateLimit { get; set; }

        public bool AniDbReplaceGraves { get; set; }

        public bool AniListShowSpoilerTags { get; set; }
    }
}
