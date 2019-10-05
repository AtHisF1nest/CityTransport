using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using citytransportAPI.Dtos;
using Core.Data.Models;
using Core.Data.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace citytransportAPI.Controllers
{
    [Authorize]
    public class MapController : ApiControllerBase
    {
        private readonly DataContext _dataContext;
        public MapController(DataContext dataContext)
        {
            _dataContext = dataContext;

        }

        [Route("{cityId}")]
        public async Task<IActionResult> GetFields(int cityId)
        {
            //AddFields();

            var mapFields = await _dataContext.MapFields
                            .Include(x => x.Photo)
                            .Where(x => x.CityId == cityId)
                            .OrderBy(x => x.GridY)
                            .ThenBy(x => x.GridX)
                            .ToListAsync();
            var res = new List<MapFieldDto>();

            foreach (var item in mapFields)
            {
                res.Add(new MapFieldDto()
                {
                    Name = item.ElementType.ToString(),
                    XCord = item.GridX,
                    YCord = item.GridY,
                    GridWidth = item.GridWidth,
                    GridHeight = item.GridHeight,
                    PhotoPath = item.Photo.SourcePath,
                    ElementType = item.ElementType
                });
            }

            return Ok(res);
        }

        //Developerska metoda
        public IActionResult AddFields()
        {
            if (!_dataContext.Photos.Any())
            {
                _dataContext.Photos.Add(new Photo()
                {
                    Id = 1,
                    SourcePath = "fields/empty.png"
                });
                _dataContext.Photos.Add(new Photo()
                {
                    Id = 2,
                    SourcePath = "fields/roadHorizontal.png"
                });
                _dataContext.Photos.Add(new Photo()
                {
                    Id = 3,
                    SourcePath = "fields/roadVertical.png"
                });
            }
            if (!_dataContext.MapFields.Any())
            {
                for (int y = 0; y < 15; y++)
                {
                    for (int x = 0; x < 30; x++)
                    {
                        _dataContext.MapFields.Add(
                            new MapField()
                            {
                                ElementType = ElementType.Empty,
                                CityId = 1,
                                GridX = x,
                                GridY = y,
                                GridWidth = 1,
                                GridHeight = 1,
                                Visible = true,
                                PhotoId = 1
                            }
                        );
                    }
                }


            }
            _dataContext.SaveChanges();
            return Ok();
        }
    }
}