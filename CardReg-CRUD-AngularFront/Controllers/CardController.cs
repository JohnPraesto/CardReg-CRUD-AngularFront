using CardReg_CRUD_AngularFront.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CardReg_CRUD_AngularFront.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly CardDbContext _context;
        public CardController(CardDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCards()
        {
            var cards = await _context.Cards.ToListAsync();
            return Ok(cards);
        }

        [HttpGet]
        [Route("{id:guid}")]
        [ActionName("GetSingleCard")]
        public async Task<IActionResult> GetCard([FromRoute] Guid id)
        {
            Card card = await _context.Cards.FirstOrDefaultAsync(c => c.Id == id);
            if(card != null)
            {
                return Ok(card);
            }
            else
            {
                return NotFound("Card not found");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddCard([FromBody] Card card)
        {
            card.Id = Guid.NewGuid();
            await _context.Cards.AddAsync(card);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCard), new {id = card.Id}, card);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteCard([FromRoute] Guid id)
        {
            Card card = await _context.Cards.FirstOrDefaultAsync(c => c.Id == id);

            if(card == null)
            {
                return NotFound("Card not found");
            }

            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();
            return Ok(card);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateCard([FromRoute] Guid id, [FromBody] Card card)
        {
            var cardToUpdate = await _context.Cards.FirstOrDefaultAsync(c => c.Id == id);
            if(cardToUpdate != null)
            {
                cardToUpdate.CardNumber = card.CardNumber;
                cardToUpdate.CVC = card.CVC;
                cardToUpdate.ExpireMonth = card.ExpireMonth;
                cardToUpdate.ExpireYear = card.ExpireYear;
                cardToUpdate.HolderName = card.HolderName;
                await _context.SaveChangesAsync();
                return Ok(card);
            }

            return NotFound("Kortet hittades inte");
            //Card newCard = _context.Cards.Find(card);
            //newCard.CardNumber = card.CardNumber;
            //newCard.CVC = card.CVC;
            //newCard.ExpireMonth = card.ExpireMonth;
            //newCard.ExpireYear = card.ExpireYear;
            //newCard.HolderName = card.HolderName;
            //newCard.Id = card.Id;
            //await _context.SaveChangesAsync();
            //return Ok(newCard);
        }
    }
}
