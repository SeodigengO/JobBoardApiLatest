using AutoMapper;
using JobBoard.Models.Dto;

public class CompanyService
{
  private readonly ICompanyRepository companyRepository;
  private readonly IMapper mapper;

  public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
  {
    this.companyRepository = companyRepository;
    this.mapper = mapper;
  }

  public async Task<List<CompanyResponseDto>> GetAllCompanies()
  {
    var companies = await companyRepository.GetAllCompanies();
    return mapper.Map<List<CompanyResponseDto>>(companies);
}

}