using Microsoft.AspNetCore.Mvc;
using OnboardingApi.DTOs.Personal;
using OnboardingApi.Services.Interfaces;

namespace OnboardingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonalsController : ControllerBase
{
    private readonly IPersonalService _service;

    public PersonalsController(IPersonalService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var personal = await _service.GetByIdAsync(id);

        if (personal == null)
            return NotFound();

        return Ok(personal);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreatePersonalDto dto)
    {
        var created = await _service.CreateAsync(dto);

        return CreatedAtAction(
            nameof(GetById),
            new { id = created.Id },
            created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdatePersonalDto dto)
    {
        var updated = await _service.UpdateAsync(id, dto);

        if (!updated)
            return NotFound();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _service.DeleteAsync(id);

        if (!deleted)
            return NotFound();

        return NoContent();
    }
}