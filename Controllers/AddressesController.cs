using Microsoft.AspNetCore.Mvc;
using OnboardingApi.DTOs.Address;
using OnboardingApi.Services.Interfaces;

namespace OnboardingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AddressesController : ControllerBase
{
    private readonly IAddressService _service;

    public AddressesController(IAddressService service)
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
        var address = await _service.GetByIdAsync(id);

        if (address == null)
            return NotFound();

        return Ok(address);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateAddressDto dto)
    {
        var created = await _service.CreateAsync(dto);

        return Ok(created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateAddressDto dto)
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