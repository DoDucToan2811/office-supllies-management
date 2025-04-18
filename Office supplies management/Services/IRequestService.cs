﻿using Office_supplies_management.DTOs.Request;
using Office_supplies_management.Features.Request.Commands;

namespace Office_supplies_management.Services
{
    public interface IRequestService
    {
        Task<List<RequestDto>> GetByUserID(int userId);
        Task<RequestDto> Create(CreateRequestDto createRequest);
        Task<List<RequestDto>> GetAll();
        Task<RequestDto> GetByID(int id);
        Task<bool> Update(UpdateRequestDto updateRequest);
        Task<bool> DeleteByID(int id);
        Task<int> Count();
        Task<List<RequestDto>> GetByDepartment(string department);
        Task<bool> ApproveByDepLeader(int requestID, string note);
        Task<List<RequestDto>> GetApprovedRequestsByDepLeader();
        Task<bool> ApproveByFinEmployee(int requestId, string note);
        Task<List<RequestDto>> GetAllRequestsForFinEmployee();
        Task<bool> NotApproveRequestByDepLeader(int requestID, string note);
        Task<bool> NotApproveRequestByFinEmployee(int requestID, string note);
        Task UpdateRequestStatus(int summaryID, bool isProcessedBySupLead, bool isApprovedBySupLead);
        Task<List<RequestDto>> GetCollectedRequests(); // Add this method
        Task<List<RequestDto>> GetRequestsInApprovedSummary(); // New method
        Task<List<RequestDto>> GetRequestsInDateRange(DateTime startDate, DateTime endDate);
        Task<List<RequestDto>> GetApprovedRequestsByDepartment(string department);
        Task<List<RequestDto>> GetApprovedRequestsByDateRangeAndDepartment(DateTime startDate, DateTime endDate, string department);
        Task<List<RequestDto>> GetRequestsByProductID(int productID);
        Task<bool> RecalculateTotalPrice(int requestID);
        Task<bool> RecalculateAllRequestsTotalPrice();
        Task<bool> AdjustDatesByAdding7Hours();
        Task<bool> ResetApprovalDatesAsync();
    }
}
