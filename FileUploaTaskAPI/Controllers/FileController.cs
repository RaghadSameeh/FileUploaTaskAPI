using BussienesLayer.DTO;
using DataAccessLayer.Models;
using DataAccessLayer.Reposatries.DataFileReposatry;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileUploadTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {

        private readonly IFileReposatry _fileReposatry;

        public FileController(IFileReposatry fileReposatry)
        {
            _fileReposatry = fileReposatry;
        }

        [HttpPost("saveData")] 
        public ActionResult<DTOResult> Data([FromBody]DataFile[] data)
        {
            DTOResult result = new DTOResult();

            if (ModelState.IsValid)
            {
                foreach (var item in data)
                {
                    try
                    {
                        _fileReposatry.insert(item);
                        _fileReposatry.save();
                        

                        result.IsPass = true;
                        result.Data = $"Data Saved Successfuly with ID {item.Id}";
                    }
                    catch (Exception ex)
                    {
                        result.IsPass = false;
                        result.Data = $"An error{ex.Message} occurred while saving Data.";
                    }

                }
               
            }
            else
            {
                result.IsPass = false;
                result.Data = ModelState.Values.SelectMany(e => e.Errors)
                    .Select(e => e.ErrorMessage).ToList();
            }
            return result;
        }


        [HttpPost("getData")]
        public ActionResult<DTOResult> getAll([FromBody]string keyword)
        {
            DTOResult dTOResult = new DTOResult();
            List<DataFile> data = _fileReposatry.DataBasedOnKeyword(keyword);
            dTOResult.Data= data;
            dTOResult.IsPass = true;
            return dTOResult;

        }
    }
}
