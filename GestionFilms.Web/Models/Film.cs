using System.ComponentModel.DataAnnotations;

namespace GestionFilms.Web.Models;

public class Film
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Le titre est obligatoire")]
    [StringLength(120)]
    public string Titre { get; set; } = string.Empty;

    [Required(ErrorMessage = "Le réalisateur est obligatoire")]
    [StringLength(120)]
    public string Realisateur { get; set; } = string.Empty;

    [Range(1900, 2100, ErrorMessage = "Année invalide")]
    [Display(Name = "Année de sortie")]
    public int AnneeSortie { get; set; }

    [Required(ErrorMessage = "Le genre est obligatoire")]
    [StringLength(80)]
    public string Genre { get; set; } = string.Empty;

    [Range(0, 10, ErrorMessage = "La note doit être entre 0 et 10")]
    public double Note { get; set; }
}
