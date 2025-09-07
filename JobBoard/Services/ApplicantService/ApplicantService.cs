using AutoMapper;
using JobBoard.Models;

public class ApplicantService
{
  private readonly IApplicantRepository applicantRepository;
  private readonly IMapper mapper;

  public ApplicantService(IApplicantRepository applicantRepository, IMapper mapper)
  {
    this.applicantRepository = applicantRepository;
    this.mapper = mapper;
  }

  public async Task<ResponseApplicantDto> AddApplicant(PostApplicantDto applicantDto)
  {
        var applicantEntity = mapper.Map<Applicant>(applicantDto);
        var savedApplicant = await applicantRepository.AddApplicant(applicantEntity);
        var responseDto = mapper.Map<ResponseApplicantDto>(savedApplicant);
        return responseDto;
  }
}