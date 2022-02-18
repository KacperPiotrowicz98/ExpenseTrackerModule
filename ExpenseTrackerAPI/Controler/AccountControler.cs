

using ExpenseTrackerAPI.Menagers.UserAccountsMenagers;
using ExpenseTrackerAPI.Requests.UserAccount;
using ExpenseTrackerAPI.Responses;
using ExpenseTrackerAPI.Responses.UserAccount;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ExpenseTrackerAPI.Controler
{
    [Microsoft.AspNetCore.Mvc.Route(Route)]
    [ApiController]
    public class ExpenseTrackerController : ControllerBase
    {
       public const string Route = "api/UserAccount";
        private readonly IUserAccountManager _userAccountManager;
        public ExpenseTrackerController(IUserAccountManager userAccountManager)
        {
            _userAccountManager = userAccountManager;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [SwaggerOperation(
              Summary = "Gets a AllUserAccounts ",
              Description = "Returns the AllUserAccounts",
              OperationId = "AccountControler.GetAll"
              )
          ]
        public async Task<ActionResult<AccountGetResponse>> GetAll()
        {
            var response = await _userAccountManager.GetAllUserAccounts();
            return Ok(response);
        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [SwaggerOperation(
             Summary = "Gets a UserAccounts by Id",
             Description = "Returns the UserAccounts",
             OperationId = "UserAccounts.GetUserAccountbyId")
            ]
        public async Task<ActionResult<AccountGetResponse>> GetById(int id)
        {
            var response = await _userAccountManager.GetUserAccountbyId(id);
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [SwaggerOperation(
            Summary = "Creates new UserAccount",
            Description = "Creates new UserAccount",
            OperationId = "UserAccount.Create")]

        public async Task<ActionResult<UserAccountCreateResponse>> Create([FromBody] UserAccountCreateRequest? request)
        {
            var response = await _userAccountManager.CreateUserAccountAsync(request);
            return Created($"{Route}/{response.Id}", response);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [SwaggerOperation(
           Summary = "Updates UserAccount by Id",
           Description = "Updates UserAccount by Id",
           OperationId = "UserAccount.UpdateById"
           )
       ]
        public async Task<ActionResult> UpdateById(int id, [FromBody] UserAccountPutRequest? putRequest)
        {
            await _userAccountManager.UpdateTeamByIdAsync(id, putRequest);
            return Ok();
        }


    }
}
