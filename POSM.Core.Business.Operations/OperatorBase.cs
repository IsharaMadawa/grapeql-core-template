﻿using Microsoft.Extensions.Options;
using POSM.Core.Data.Db.Models;
using POSM.Fx.Cryptography.Interfaces;
using POSM.FX.Security.Interfaces;
using POSM.FX.Security.OpenIDConnect;

namespace POSM.Core.Business.Operations
{
	public class OperatorBase
	{
		protected readonly POSMDbContext dbContext;
        protected readonly IOptions<TokenSettings> tokenSettings;
        protected readonly IPOSMHasher posmHasher;
        protected readonly ITokenValidator tokenValidator;

        public OperatorBase(POSMDbContext dbContext = null, IPOSMHasher posmHasher = null, IOptions<TokenSettings> tokenSettings = null, ITokenValidator tokenValidator = null)
        {
            this.dbContext = dbContext;
            this.posmHasher = posmHasher;
            this.tokenSettings = tokenSettings;
            this.tokenValidator = tokenValidator;
        }

        public void SaveChanges()
        {
            if (dbContext != null)
            {
                dbContext.SaveChanges();
            }
        }
    }
}
