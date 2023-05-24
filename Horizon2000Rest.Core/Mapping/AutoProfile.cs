using AutoMapper;
using Horizon2000Rest.Core.Models.Product;
using Horizon2000Rest.Core.Models.ProductCategory;
using Horizon2000Rest.Core.Models.Student;
using Horizon2000Rest.Core.Models.User;
using Horizon2000Rest.Entity.Models;
using Horizon2000Rest.Core.Models.Advert;
using Horizon2000Rest.Core.Models.Course;
using Horizon2000Rest.Core.Models.ParentCourse;
using Horizon2000Rest.Core.Models.Schedule;

namespace Horizon2000Rest.Core.Profiles
{
    /// <summary>
    /// AutoMapper profile for mapping between ModelsDbo and ModelsDto.
    /// </summary>
    public class AutoProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the AutoProfile class.
        /// </summary>
        public AutoProfile()
        {
            // Map AdvertDbo to AdvertDtos
            CreateMap<AdvertDbo, AddAdvertDto>().ReverseMap();
            CreateMap<AdvertDbo, GetAdvertDto>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.ID))
                .ForMember(
                    dest => dest.Image,
                    opt => opt.MapFrom(src => File.ReadAllBytes(src.Path)))
                .ForMember(
                    dest => dest.ImageFileType,
                    opt => opt.MapFrom(src => MimeTypes.GetMimeType(Path.GetFileName(src.Path)))
                    ).ReverseMap();

            // Map CourseDbo to CourseDtos
            CreateMap<CourseDbo, BaseCourseDto>().ReverseMap();
            CreateMap<CourseDbo, CreateCourseDto>().ReverseMap();
            CreateMap<CourseDbo, GetCourseDto>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.ID))
                .ForMember(dest =>
                    dest.Image,
                    opt => opt.MapFrom(src => File.ReadAllBytes(src.ImagePath)))
                .ForMember(dest =>
                    dest.ImageFileType,
                    opt => opt.MapFrom(src => MimeTypes.GetMimeType(Path.GetFileName(src.ImagePath)))
                    ).ReverseMap();

            CreateMap<CourseDbo, GetCourseFullDetailDto>().ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.ID))
                .ForMember(
                    dest => dest.ParentCourseId,
                    opt => opt.MapFrom(src => src.ParentCourseId)
                    ).ReverseMap();

            CreateMap<CourseDbo, GetCourseListDto>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.ID)
                    ).ReverseMap();

            CreateMap<CourseDbo, GetParentCourseListDto>().ReverseMap();
            CreateMap<CourseDbo, UpdateCourseDto>().ReverseMap();

            // Map ParentCourseDbo to ParentCourseDtos
            CreateMap<ParentCourseDbo, GetActiveParentCourseDto>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.ID))
                .ForMember(
                    dest => dest.Image,
                    opt => opt.MapFrom(src => File.ReadAllBytes(src.ImagePath)))
                .ForMember(
                    dest => dest.FileType,
                    opt => opt.MapFrom(src => MimeTypes.GetMimeType(Path.GetFileName(src.ImagePath)))
                    ).ReverseMap();

            // Map ProductDbo to ProductDtos
            CreateMap<ProductDbo, AddProductDto>().ReverseMap();
            CreateMap<ProductDbo, BaseProductDto>().ReverseMap();
            CreateMap<ProductDbo, GetProductDto>().ReverseMap();
            CreateMap<ProductDbo, ProductDto>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.ID))
                .ForMember(
                    dest => dest.CategoryId,
                    opt => opt.MapFrom(src => src.CategoryID)
                ).ReverseMap();

            CreateMap<ProductDbo, UpdateProductDto>().ReverseMap();

            // Map ProductCategoryDbo to ProductCategoryDtos
            CreateMap<ProductCategoryDbo, ProductCategoryDto>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.ID)
                ).ReverseMap();
            CreateMap<ProductCategoryDbo, UpdateProductCategoryDto>().ReverseMap();

            // Map ScheduleDbo to ScheduleDtos
            CreateMap<ScheduleDbo, AddScheduleDto>().ReverseMap();
            CreateMap<ScheduleDbo, BaseScheduleDto>().ReverseMap();
            CreateMap<ScheduleDbo, GetScheduleDto>().ReverseMap();
            CreateMap<ScheduleDbo, UpdateScheduleDto>().ReverseMap();

            // Map StudentDbo to StudentDtos
            CreateMap<StudentDbo, GetStudentDto>().ReverseMap();
            CreateMap<StudentDbo, StudentDto>().ReverseMap();

            // Map UserDbo to UserDto
            CreateMap<UserDbo, UserDto>().ReverseMap();

            // Map UserRoleDbo to UserRoleDto
            CreateMap<UserRoleDbo, UserRoleDto>().ReverseMap();

        }
    }
}
