﻿using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Transactions
{
    public class GetSimpleTransactionDtos
    {
        public string TranscationCode { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public int Amount { get; set; }
        public TransactionMethod Method { get; set; }
        public TransactionStatus Status { get; set; }
        public TransactionType Type { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<Guid> TransactionSlot { get; set; } = new List<Guid>();
    }
}
