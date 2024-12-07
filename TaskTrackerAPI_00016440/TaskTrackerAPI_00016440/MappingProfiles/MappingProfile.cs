using AutoMapper;
using TaskTrackerAPI_00016440.DTOs;
using TaskTrackerAPI_00016440.Models;

namespace TaskTrackerAPI_00016440.MappingProfiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Map Dto to Model and Model to Dto
            CreateMap<TaskDto, TaskModel>().ReverseMap();
            CreateMap<UserDto, UserModel>().ReverseMap();
        }
    }
}
