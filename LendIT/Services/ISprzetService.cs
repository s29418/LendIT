using LendIT.DTOs;
using LendIT.Models.Entities;

namespace LendIT.Services;

public interface ISprzetService
{
    Task DodajAsync(SprzetCreateDto dto);
    Task EdytujAsync(int id, SprzetUpdateDto dto);
    Task UsunAsync(int id);
}
