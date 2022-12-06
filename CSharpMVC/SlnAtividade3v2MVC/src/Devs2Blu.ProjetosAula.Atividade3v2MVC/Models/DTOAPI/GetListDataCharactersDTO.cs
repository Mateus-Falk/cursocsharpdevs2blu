namespace Devs2Blu.ProjetosAula.Atividade3v2MVC.Models.DTOAPI
{
    public class GetListDataCharactersDTO
    {
        public bool success { get; set; }
        public int count { get; set; }
        public List<CharacterDTO> data { get; set; }
        
    }
}
