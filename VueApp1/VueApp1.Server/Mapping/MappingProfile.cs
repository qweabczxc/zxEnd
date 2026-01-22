using AutoMapper;
using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;

namespace VueApp1.Server.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // === REQUEST → ENTITY ===

            // CreateInstructionRequest → InstructionsEntity
            CreateMap<CreateInstructionRequest, InstructionsEntity>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Employee, opt => opt.Ignore())
                .ForMember(dest => dest.Program, opt => opt.Ignore())
                .ForMember(dest => dest.Documents, opt => opt.Ignore())
                .AfterMap((src, dest) => {
                    if (src.Documents != null)
                    {
                        dest.Documents = src.Documents.Select(d => new InstructionDocumentEntity
                        {
                            FileName = d.FileName,
                            FilePath = d.FilePath,
                            UploadedAt = DateTime.UtcNow
                        }).ToList();
                    }
                });

            // UpdateInstructionRequest → InstructionsEntity
            CreateMap<UpdateInstructionRequest, InstructionsEntity>()
                .ForMember(dest => dest.Employee, opt => opt.Ignore())
                .ForMember(dest => dest.Program, opt => opt.Ignore())
                .ForMember(dest => dest.Documents, opt => opt.Ignore());

            // CreateDocumentRequest → InstructionDocumentEntity
            CreateMap<CreateDocumentRequest, InstructionDocumentEntity>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.InstructionId, opt => opt.Ignore())
                .ForMember(dest => dest.Instruction, opt => opt.Ignore())
                .ForMember(dest => dest.UploadedAt, opt => opt.MapFrom(_ => DateTime.UtcNow));

            // === ENTITY → RESPONSE ===

            // InstructionsEntity → InstructionResponse
            CreateMap<InstructionsEntity, InstructionResponse>()
                .ForMember(dest => dest.Employee, opt => opt.MapFrom(src => src.Employee))
                .ForMember(dest => dest.Program, opt => opt.MapFrom(src => src.Program))
                .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

            // EmployeeEntity → EmployeeShortResponse
            CreateMap<EmployeeEntity, EmployeeResponse>()
                .ForMember(dest => dest.InstructionSchedules,
                    opt => opt.MapFrom(src => src.InstructionSchedules));

            // InstructionProgramEntity → ProgramResponse
            CreateMap<InstructionProgramEntity, ProgramResponse>()
                .ForMember(dest => dest.InstructionType,
                    opt => opt.MapFrom(src => src.InstructionType))
                .ForMember(dest => dest.InstructionSchedules,
                    opt => opt.MapFrom(src => src.InstructionSchedules));

            // InstructionTypeEntity → InstructionTypeResponse
            CreateMap<InstructionTypeEntity, InstructionTypeResponse>();

            // InstructionDocumentEntity → DocumentResponse
            CreateMap<InstructionDocumentEntity, DocumentResponse>();

            // InstructionScheduleEntity → InstructionScheduleResponse
            CreateMap<InstructionScheduleEntity, InstructionScheduleResponse>();

            // === КОРОТКИЕ ВЕРСИИ (для вложенных объектов) ===
            CreateMap<EmployeeEntity, EmployeeResponse>()
                .ForMember(dest => dest.InstructionSchedules, opt => opt.Ignore());

            CreateMap<InstructionProgramEntity, ProgramResponse>()
                .ForMember(dest => dest.InstructionSchedules, opt => opt.Ignore())
                .ForMember(dest => dest.InstructionType, opt => opt.Ignore());
        }
    }
}
