﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Common;
using SmiteRepository.Sqlserver;
using SmiteRepository;
namespace TaskManager.Repositories
{
    public class TaskRepository : BaseRepository
    {
        public TaskRepository() : base(AppConfig.Conn_Task)
        {
            
        }

        public bool AllocationTask(int serverCount,int runServerId, int serverIndex) {

            const string sql = @"update ts_Tasks set RunServerId=@RunServerId from ts_Tasks  where CONVERT(int,CONVERT(varbinary,Right([Guid],1)))%@ServerCount=@ServerIndex";
            return base.ExecuteCommand(sql, new
            {
                ServerCount = serverCount,
                RunServerId = runServerId,
                ServerIndex=serverIndex
            }) > 0;
        }

    }
}
