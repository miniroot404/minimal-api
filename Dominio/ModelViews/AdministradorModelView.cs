using MinimalApi.Enuns;

namespace   MinimalApi.Dominio.ModelViews;

public record AdmisnistradorModelView
{ 
    public int Id { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Perfil { get; set; } = default!;
}