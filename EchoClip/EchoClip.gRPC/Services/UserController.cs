using EchoClip.gRPC.Interfaces;
using EchoClip.Models;
using Grpc.Core;

namespace EchoClip.gRPC.Services;

class UserController(ILogger<AuthController> logger, IUserService userService, UserFromTokenReader userFromTokenReader) : gRPC.UserController.UserControllerBase
{
    private readonly ILogger<AuthController> _logger = logger;
    private readonly IUserService _userService = userService;
    private readonly UserFromTokenReader _userFromTokenReader = userFromTokenReader;

    public override Task<CreateUserResponse> CreateUser(CreateUserRequest request, ServerCallContext context)
    {
        _userService.CreateUser(request.Username, request.Password, request.Email, request.Name, request.Surname);

        return Task.FromResult(new CreateUserResponse
        {
            Username = request.Username,
            Email = request.Email,
        });
    }

    public override Task<GetFriendsResponse> GetFriends(GetFriendsRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        List<User> friends = _userService.GetUsersThatUserSetStatus(myId, "ACCEPTED");
        List<RelatedUserMessage> relatedUserMessages = friends.Select(friend => new RelatedUserMessage
        {
            Id = friend.UserId.ToString(),
            Username = friend.Username,
            Name = friend.Name,
            Surname = friend.Surname
        }).ToList();

        return Task.FromResult(new GetFriendsResponse
        {
            Friends = { relatedUserMessages }
        });
    }

    public override Task<GetInvitedFriendsResponse> GetInvitedFriends(GetInvitedFriendsRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        List<User> invitedFriends = _userService.GetUsersThatUserSetStatus(myId, "PENDING");
        List<RelatedUserMessage> relatedUserMessages = invitedFriends.Select(invitedFriend => new RelatedUserMessage
        {
            Id = invitedFriend.UserId.ToString(),
            Username = invitedFriend.Username,
            Name = invitedFriend.Name,
            Surname = invitedFriend.Surname
        }).ToList();

        return Task.FromResult(new GetInvitedFriendsResponse
        {
            FiendsWhoIInvited = { relatedUserMessages }
        });
    }

    public override Task<GetInvitationsForMeResponse> GetInvitationsForMe(GetInvitationsForMeRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        List<User> friendsWhoInvitedMe = _userService.GetUsersWhoSetUserStatus(myId, "PENDING");
        List<RelatedUserMessage> relatedUserMessages = friendsWhoInvitedMe.Select(friendWhoInvitedMe => new RelatedUserMessage
        {
            Id = friendWhoInvitedMe.UserId.ToString(),
            Username = friendWhoInvitedMe.Username,
            Name = friendWhoInvitedMe.Name,
            Surname = friendWhoInvitedMe.Surname
        }).ToList();

        return Task.FromResult(new GetInvitationsForMeResponse
        {
            FiendsWhoInvitedMe = { relatedUserMessages }
        });
    }

    public override Task<GetRejectedFriendsResponse> GetRejectedFriends(GetRejectedFriendsRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        List<User> rejectedFrineds = _userService.GetUsersThatUserSetStatus(myId, "REJECTED");
        List<RelatedUserMessage> relatedUserMessages = rejectedFrineds.Select(rejectedFrined => new RelatedUserMessage
        {
            Id = rejectedFrined.UserId.ToString(),
            Username = rejectedFrined.Username,
            Name = rejectedFrined.Name,
            Surname = rejectedFrined.Surname
        }).ToList();

        return Task.FromResult(new GetRejectedFriendsResponse
        {
            RejectedFriends = { relatedUserMessages }
        });
    }

    public override Task<AcceptFriendResponse> AcceptFriend(AcceptFriendRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        _userService.SetRelationToUser(myId, Guid.Parse(request.UserFriendId), "ACCEPTED");
        return Task.FromResult(new AcceptFriendResponse { });
    }

    public override Task<RejectFriendResponse> RejectFriend(RejectFriendRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        _userService.SetRelationToUser(myId, Guid.Parse(request.UserFriendId), "PENDING"); 
        return Task.FromResult(new RejectFriendResponse { });
    }

    public override Task<SendFriendInvitationResponse> SendFriendInvitation(SendFriendInvitationRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        _userService.SetRelationToUser(myId, Guid.Parse(request.UserFriendId), "REJECTED");
        return Task.FromResult(new SendFriendInvitationResponse { });
    }
}