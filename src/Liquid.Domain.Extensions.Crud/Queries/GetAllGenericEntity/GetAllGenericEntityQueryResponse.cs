﻿using System.Collections.Generic;

namespace Liquid.Domain.Extensions.Crud.Queries.GetAllGenericEntity
{
    /// <summary>
    /// Response of <see cref="GetAllGenericEntityQuery{TEntity, TIdentifier}"/>
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class GetAllGenericEntityQueryResponse<TEntity>
    {
        /// <summary>
        /// Collection of <see cref="TEntity"/>
        /// </summary>
        public IEnumerable<TEntity> Data { get; set; }

        /// <summary>
        /// Initialize an instance of <see cref="GetAllGenericEntityQueryResponse{TEntity}"/>
        /// </summary>
        /// <param name="data">Collection of <see cref="TEntity"/></param>
        public GetAllGenericEntityQueryResponse(IEnumerable<TEntity> data)
        {
            Data = data;
        }
    }
}