using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuoLingQCombiner.Models
{
    public partial class MockDuolingoUser
    {
        public bool? FilterStream { get; set; }
        public LanguageData LanguageData { get; set; }
        public LastStreak LastStreak { get; set; }
        public bool? PushActivityReply { get; set; }
        public bool? Deactivated { get; set; }
        public bool? AutoFacebookPost { get; set; }
        public bool? PushClubs { get; set; }
        public long? SiteStreak { get; set; }
        public bool? NotifyClassroomJoin { get; set; }
        public bool? SoundEffects { get; set; }
        public bool? PushEditSuggested { get; set; }
        public bool? PushFollow { get; set; }
        public List<LanguageElement> Languages { get; set; }
        public string Location { get; set; }
        public string FacebookId { get; set; }
        public string BrowserLanguage { get; set; }
        public long? CreatedDt { get; set; }
        public string Username { get; set; }
        public string Bio { get; set; }
        public bool? InsiteSentenceEdited { get; set; }
        public bool? NotifyActivityReply { get; set; }
        public DuolingoUserTrackingProperties TrackingProperties { get; set; }
        public bool? PushComment { get; set; }
        public PrivacySettings PrivacySettings { get; set; }
        public bool? NotifyActivityComment { get; set; }
        public bool? EmailStreakSaver { get; set; }
        public bool? RequiresParentalConsent { get; set; }
        public bool? TrialAccount { get; set; }
        public bool? Transliterate { get; set; }
        public bool? NotifyAssignmentComplete { get; set; }
        public object TwitterId { get; set; }
        public Dictionary<string, InformantReference> InformantReference { get; set; }
        public bool? NotifyAssignment { get; set; }
        public string Avatar { get; set; }
        public bool? StreakExtendedToday { get; set; }
        public string UiLanguage { get; set; }
        public bool? NotifyStreamPost { get; set; }
        public string Fullname { get; set; }
        public bool? NotifyPass { get; set; }
        public bool? NotifyAnnouncement { get; set; }
        public bool? UploadSelfService { get; set; }
        public bool? HasObserver { get; set; }
        public bool? PushPassed { get; set; }
        public bool? PushPromotion { get; set; }
        public DateTimeOffset? CreationDate { get; set; }
        public bool? PushStreakFreezeUsed { get; set; }
        public bool? PushActivityComment { get; set; }
        public string Timezone { get; set; }
        public List<Calendar> Calendar { get; set; }
        public long? Id { get; set; }
        public long? CurrentTime { get; set; }
        public bool? PushLeaderboards { get; set; }
        public bool? PushAnnouncement { get; set; }
        public bool? AdsEnabled { get; set; }
        public bool? ChangeDesign { get; set; }
        public bool? Speaker { get; set; }
        public Inventory Inventory { get; set; }
        public bool? IsSelfObserver { get; set; }
        public List<object> NotifEventIds { get; set; }
        public LanguageString? LearningLanguageString { get; set; }
        public bool? PushStreamPost { get; set; }
        public string Email { get; set; }
        public bool? WeekOldAccount { get; set; }
        public long? DailyGoal { get; set; }
        public bool? EmailPromotion { get; set; }
        public bool? NotifySchoolsAnnouncement { get; set; }
        public object Cohort { get; set; }
        public string TimezoneOffset { get; set; }
        public bool? Microphone { get; set; }
        public long? NumClassrooms { get; set; }
        public long? SnoozeExpirationTime { get; set; }
        public long? Rupees { get; set; }
        public Uri InviteUrl { get; set; }
        public AbOptions AbOptions { get; set; }
        public bool? IsObserver { get; set; }
        public bool? NotifyWeeklyReport { get; set; }
        public bool? DeletePermissions { get; set; }
        public bool? NotifyComment { get; set; }
        public bool? InsiteImmersionLingots { get; set; }
        public bool? NotifyEditSuggested { get; set; }
        public bool? NotifyWeeklyProgressReport { get; set; }
        public string Created { get; set; }
        public bool? Admin { get; set; }
        public bool? EmailVerified { get; set; }
        public LearningLanguageEnum? LearningLanguage { get; set; }
        public bool? NotifyClassroomLeave { get; set; }
        public long? NumObservees { get; set; }
        public bool? EmailWordOfTheDay { get; set; }
        public bool? NotifyClubs { get; set; }
        public bool? FreezePermissions { get; set; }
        public object GplusId { get; set; }
        public bool? NotifyFollow { get; set; }
        public bool? EmailStreakFreezeUsed { get; set; }
        public bool? PushStreakSaver { get; set; }
        public bool? Autoplay { get; set; }
    }

    public partial class AbOptions
    {
    }

    public partial class Calendar
    {
        public string SkillId { get; set; }
        public long? Improvement { get; set; }
        public EventType? EventType { get; set; }
        public long? Datetime { get; set; }
    }

    public partial class InformantReference
    {
        public List<string> Contexts { get; set; }
        public bool? Treated { get; set; }
        public string Destiny { get; set; }
        public string Condition { get; set; }
        public bool? Eligible { get; set; }
    }

    public partial class Inventory
    {
        public DateTimeOffset? IdiomsFr { get; set; }
        public DateTimeOffset? SuperheroOutfit { get; set; }
        public DateTimeOffset? LuxuryOutfit { get; set; }
        public DateTimeOffset? TimedPractice { get; set; }
        public DateTimeOffset? StreakRepair { get; set; }
        public DateTimeOffset? PremiumSubscription { get; set; }
        public DateTimeOffset? FlirtingIt { get; set; }
        public DateTimeOffset? FlirtingFr { get; set; }
    }

    public partial class LanguageData
    {
        public Fr Fr { get; set; }
    }

    public partial class Fr
    {
        public long? Streak { get; set; }
        public LanguageString? LanguageString { get; set; }
        public long? LevelProgress { get; set; }
        public bool? FirstTime { get; set; }
        public List<long> BonusRows { get; set; }
        public long? PointsRank { get; set; }
        public long? FluencyScore { get; set; }
        public bool? PushPractice { get; set; }
        public List<LevelTest> LevelTests { get; set; }
        public string DirectionStatus { get; set; }
        public long? NextLevel { get; set; }
        public Uri LinkedinShareUrl { get; set; }
        public bool? NotifyPractice { get; set; }
        public Notifications Notifications { get; set; }
        public long? NotifyTime { get; set; }
        public List<PointsRankingDat> PointsRankingData { get; set; }
        public long? NumSkillsLearned { get; set; }
        public List<Calendar> Calendar { get; set; }
        public bool? CanTransliterate { get; set; }
        public long? LevelLeft { get; set; }
        public bool? NoDep { get; set; }
        public FrTrackingProperties TrackingProperties { get; set; }
        public double? LanguageStrength { get; set; }
        public NextLesson NextLesson { get; set; }
        public bool? MaxLevel { get; set; }
        public long? LevelPercent { get; set; }
        public LearningLanguageEnum? Language { get; set; }
        public long? Level { get; set; }
        public List<Skill> Skills { get; set; }
        public List<BonusSkill> BonusSkills { get; set; }
        public long? LevelPoints { get; set; }
        public List<long> AllTimeRank { get; set; }
        public long? MaxDepthLearned { get; set; }
        public long? Points { get; set; }
        public bool? ImmersionEnabled { get; set; }
        public Dictionary<string, PointsRankingDat> PointsRankingDataDict { get; set; }
        public PlacementTest PlacementTest { get; set; }
        public bool? ExemptFromHealth { get; set; }
        public long? MaxTreeLevel { get; set; }
    }

    public partial class BonusSkill
    {
        public LanguageString? LanguageString { get; set; }
        public List<object> DependenciesName { get; set; }
        public bool? PracticeRecommended { get; set; }
        public bool? Disabled { get; set; }
        public long? TestCount { get; set; }
        public long? MissingLessons { get; set; }
        public SkillProgress SkillProgress { get; set; }
        public bool? Lesson { get; set; }
        public bool? HasExplanation { get; set; }
        public string UrlTitle { get; set; }
        public string IconColor { get; set; }
        public string Category { get; set; }
        public long? NumLessons { get; set; }
        public double? Strength { get; set; }
        public bool? Beginner { get; set; }
        public string Title { get; set; }
        public long? LevelSessionsFinished { get; set; }
        public long? CoordsY { get; set; }
        public long? CoordsX { get; set; }
        public long? ProgressLevelSessionIndex { get; set; }
        public string Id { get; set; }
        public long? LevelsFinished { get; set; }
        public bool? Test { get; set; }
        public long? LessonNumber { get; set; }
        public bool? Learned { get; set; }
        public long? NumTranslationNodes { get; set; }
        public List<object> Achievements { get; set; }
        public string Description { get; set; }
        public long? Index { get; set; }
        public bool? Bonus { get; set; }
        public string Explanation { get; set; }
        public long? NumLexemes { get; set; }
        public long? NumMissing { get; set; }
        public AbOptions CommentData { get; set; }
        public List<object> Dependencies { get; set; }
        public List<string> KnownLexemes { get; set; }
        public List<string> Words { get; set; }
        public long? NumSessionsForLevel { get; set; }
        public List<object> Path { get; set; }
        public long? NumLevels { get; set; }
        public long? LearnedTs { get; set; }
        public string Short { get; set; }
        public bool? Locked { get; set; }
        public string Name { get; set; }
        public LearningLanguageEnum? Language { get; set; }
        public long? NewIndex { get; set; }
        public long? ProgressPercent { get; set; }
        public bool? Mastered { get; set; }
    }

    public partial class SkillProgress
    {
        public long? Level { get; set; }
    }

    public partial class LevelTest
    {
        public long? Index { get; set; }
        public long? Attempts { get; set; }
        public bool? Completed { get; set; }
        public long? Level { get; set; }
    }

    public partial class NextLesson
    {
        public long? LessonNumber { get; set; }
        public string SkillTitle { get; set; }
        public string SkillUrl { get; set; }
    }

    public partial class Notifications
    {
        public bool? ChromeAppAd { get; set; }
        public bool? NetPromoter { get; set; }
    }

    public partial class PlacementTest
    {
        public long? Attempts { get; set; }
    }

    public partial class PointsRankingDat
    {
        public string Username { get; set; }
        public LanguageString? LanguageString { get; set; }
        public PointsData PointsData { get; set; }
        public string Avatar { get; set; }
        public LearningLanguageEnum? Language { get; set; }
        public string Fullname { get; set; }
        public long? Id { get; set; }
        public long? Rank { get; set; }
        public bool? Self { get; set; }
    }

    public partial class PointsData
    {
        public List<object> Languages { get; set; }
        public long? Total { get; set; }
    }

    public partial class Skill
    {
        public LanguageString? LanguageString { get; set; }
        public List<string> DependenciesName { get; set; }
        public bool? PracticeRecommended { get; set; }
        public bool? Disabled { get; set; }
        public long? TestCount { get; set; }
        public long? MissingLessons { get; set; }
        public SkillProgress SkillProgress { get; set; }
        public bool? Lesson { get; set; }
        public HasExplanation? HasExplanation { get; set; }
        public string UrlTitle { get; set; }
        public IconColor? IconColor { get; set; }
        public string Category { get; set; }
        public long? NumLessons { get; set; }
        public double? Strength { get; set; }
        public bool? Beginner { get; set; }
        public string Title { get; set; }
        public long? LevelSessionsFinished { get; set; }
        public long? CoordsY { get; set; }
        public long? CoordsX { get; set; }
        public long? ProgressLevelSessionIndex { get; set; }
        public string Id { get; set; }
        public long? LevelsFinished { get; set; }
        public bool? Test { get; set; }
        public long? LessonNumber { get; set; }
        public bool? Learned { get; set; }
        public long? NumTranslationNodes { get; set; }
        public List<object> Achievements { get; set; }
        public string Description { get; set; }
        public long? Index { get; set; }
        public bool? Bonus { get; set; }
        public string Explanation { get; set; }
        public long? NumLexemes { get; set; }
        public long? NumMissing { get; set; }
        public AbOptions CommentData { get; set; }
        public List<string> Dependencies { get; set; }
        public List<string> KnownLexemes { get; set; }
        public List<string> Words { get; set; }
        public long? NumSessionsForLevel { get; set; }
        public List<object> Path { get; set; }
        public long? NumLevels { get; set; }
        public long? LearnedTs { get; set; }
        public string Short { get; set; }
        public bool? Locked { get; set; }
        public string Name { get; set; }
        public LearningLanguageEnum? Language { get; set; }
        public long? NewIndex { get; set; }
        public long? ProgressPercent { get; set; }
        public bool? Mastered { get; set; }
    }

    public partial class FrTrackingProperties
    {
        public string Direction { get; set; }
        public string LatestReferringDomain { get; set; }
        public bool? TookPlacementtest { get; set; }
        public LearningLanguageEnum? LearningLanguage { get; set; }
        public long? UtcOffset { get; set; }
        public bool? UnsafeLexemeRestriction { get; set; }
        public string UiLanguage { get; set; }
        public long? MaxTreeLevel { get; set; }
        public Uri LatestReferrer { get; set; }
    }

    public partial class LanguageElement
    {
        public long? Streak { get; set; }
        public string LanguageString { get; set; }
        public long? Points { get; set; }
        public bool? Learning { get; set; }
        public string Language { get; set; }
        public long? Level { get; set; }
        public bool? CurrentLearning { get; set; }
        public long? SentencesTranslated { get; set; }
        public long? ToNextLevel { get; set; }
    }

    public partial class LastStreak
    {
        public string ShortenedProductId { get; set; }
        public bool? IsIapPurchase { get; set; }
        public long? Length { get; set; }
        public bool? IsAvailableForRepair { get; set; }
        public string GooglePlayProductId { get; set; }
        public string ProductId { get; set; }
        public long? LastReachedGoal { get; set; }
        public long? DaysAgo { get; set; }
    }

    public partial class PrivacySettings
    {
        public bool? DisableClubs { get; set; }
        public bool? DisableDiscussions { get; set; }
        public bool? DisableEvents { get; set; }
        public bool? DisableStream { get; set; }
        public bool? DisableImmersion { get; set; }
        public bool? DisableMatureWords { get; set; }
    }

    public partial class DuolingoUserTrackingProperties
    {
        public long? Streak { get; set; }
        public List<string> Achievements { get; set; }
        public long? CreationAge { get; set; }
        public bool? HasObserver { get; set; }
        public bool? HasPicture { get; set; }
        public bool? IsAgeRestricted { get; set; }
        public string AcquisitionLastLandingPage { get; set; }
        public DateTimeOffset? CreationDate { get; set; }
        public long? NumFollowers { get; set; }
        public bool? IsPearsonUser { get; set; }
        public bool? HasItemRupeeWager { get; set; }
        public bool? HasItemWeekendAmulet { get; set; }
        public bool? DisableClubs { get; set; }
        public bool? HasFullname { get; set; }
        public long? UserId { get; set; }
        public long? Goal { get; set; }
        public string GeoipCountry { get; set; }
        public bool? DisableEvents { get; set; }
        public bool? DisableStream { get; set; }
        public bool? DisableDiscussions { get; set; }
        public bool? IsSelfObserver { get; set; }
        public bool? HasItemStreakRepair { get; set; }
        public DateTimeOffset? CreationDateNew { get; set; }
        public bool? DisableMatureWords { get; set; }
        public bool? HasItemPremiumSubscription { get; set; }
        public string Username { get; set; }
        public bool? HasItemStreakFreeze { get; set; }
        public string Direction { get; set; }
        public string LearningReason { get; set; }
        public bool? HasItemLiveSubscription { get; set; }
        public long? NumClassrooms { get; set; }
        public long? CreationDateMillis { get; set; }
        public long? DistinctId { get; set; }
        public bool? HasFacebook { get; set; }
        public long? NumObservees { get; set; }
        public Uri AcquisitionLastLandingUrl { get; set; }
        public long? SkillTreeLevel { get; set; }
        public bool? HasPhoneNumber { get; set; }
        public bool? TrialAccount { get; set; }
        public long? Level { get; set; }
        public LearningLanguageEnum? LearningLanguage { get; set; }
        public bool? DisableImmersion { get; set; }
        public long? AcquisitionLastLandingPageDate { get; set; }
        public long? LeaderboardLeague { get; set; }
        public string UiLanguage { get; set; }
        public long? Lingots { get; set; }
        public long? NumFollowing { get; set; }
    }

    public enum EventType { Lesson, Practice, Test };

    public enum LearningLanguageEnum { Fr };

    public enum LanguageString { French };

    public enum IconColor { Blue, Green, Red };

    public partial struct HasExplanation
    {
        public bool? Bool;
        public string String;

        public static implicit operator HasExplanation(bool Bool) => new HasExplanation { Bool = Bool };
        public static implicit operator HasExplanation(string String) => new HasExplanation { String = String };
        public bool IsNull => Bool == null && String == null;
    }

}
