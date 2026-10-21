using Microsoft.AspNetCore.Mvc;
using OnboardingApi.DTOs.Onboarding;
using OnboardingApi.Services.Interfaces;

namespace OnboardingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OnboardingsController : ControllerBase
{
    private readonly IOnboardingService _service;

    public OnboardingsController(IOnboardingService service)
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
        var onboarding = await _service.GetByIdAsync(id);

        if (onboarding == null)
            return NotFound();

        return Ok(onboarding);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateOnboardingDto dto)
    {
        var created = await _service.CreateAsync(dto);

        return Ok(created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateOnboardingDto dto)
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