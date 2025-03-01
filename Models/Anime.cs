using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AnimeAndMangaDatabase.Models { 
public class Anime
{
    public int Id { get; set; }

    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string? Title { get; set; }

    [DataType(DataType.Date)]
    public DateOnly DateLastWatched { get; set; }

    public ShowStatus ShowStillOngoing { get; set; }

    public DubStatus WaitingForNewDubs { get; set; }

    public SeasonStatus WaitingForNewSeason { get; set; }

    [DataType(DataType.Date)]
    public DateOnly ReleaseDateForNextSeason { get; set; }

    public Genre Genre { get; set; }

    public Anime()
    {
        ShowStillOngoing = ShowStatus.Yes;
        WaitingForNewDubs = DubStatus.Yes;
        WaitingForNewSeason = SeasonStatus.Yes;

    }
        [Required]
        [RegularExpression(@"^(G|PG|PG-13|R|NC-17)$")]
        public string? Rating { get; set; }
    }

public enum ShowStatus
{
    [Display(Name = "Yes")]
    Yes,
    [Display(Name = "No")]
    No
}

public enum DubStatus
{
    [Display(Name = "Yes")]
    Yes,
    [Display(Name = "No")]
    No
}

public enum SeasonStatus
{
    [Display(Name = "Yes")]
    Yes,
    [Display(Name = "No")]
    No
}

public enum Genre
{
    [Display(Name = "Action")]
    Action,
    [Display(Name = "Adventure")]
    Adventure,
    [Display(Name = "Comedy")]
    Comedy,
    [Display(Name = "Drama")]
    Drama,
    [Display(Name = "Fantasy")]
    Fantasy,
    [Display(Name = "Isekai")]
    Isekai,
    [Display(Name = "Sci-Fi")]
    SciFi,
    [Display(Name = "Slice of Life")]
    SliceOfLife,
    [Display(Name = "Thriller")]
    Thriller
    
}
    }