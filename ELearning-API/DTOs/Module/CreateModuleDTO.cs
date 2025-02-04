namespace ELearning_API.DTOs.Module
{
    public class CreateModuleDTO : BaseModuleDTO
    {
        public List<CreateContentDTO> Content { get; set; }
    }
}
