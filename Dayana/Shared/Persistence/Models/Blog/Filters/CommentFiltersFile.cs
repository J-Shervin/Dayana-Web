﻿using Dayana.Shared.Infrastructure.Pagination;

namespace Dayana.Shared.Persistence.Models.Blog.Filters;

public class PostCommentFilter : PaginationFilter
{
    public PostCommentFilter(int page, int pageSize) : base(page, pageSize)
    {

    }

    public string KeyWord { get; set; }

    public PostCommentSortBy? SortBy { get; set; }
}

public enum PostCommentSortBy
{
    CreationDate = 12,
    CreationDateDescending = 13,
}


public class PostCategoryCommentFilter : PaginationFilter
{
    public PostCategoryCommentFilter(int page, int pageSize) : base(page, pageSize)
    {

    }

    public string KeyWord { get; set; }

    public PostCategoryCommentSortBy? SortBy { get; set; }
}

public enum PostCategoryCommentSortBy
{
    CreationDate = 12,
    CreationDateDescending = 13,
}


public class PostCategoryIssueCommentFilter : PaginationFilter
{
    public PostCategoryIssueCommentFilter(int page, int pageSize) : base(page, pageSize)
    {

    }

    public string KeyWord { get; set; }

    public PostCategoryIssueCommentSortBy? SortBy { get; set; }
}

public enum PostCategoryIssueCommentSortBy
{
    CreationDate = 12,
    CreationDateDescending = 13,
}


public class PostIssueCommentFilter : PaginationFilter
{
    public PostIssueCommentFilter(int page, int pageSize) : base(page, pageSize)
    {

    }

    public string KeyWord { get; set; }

    public PostIssueCommentSortBy? SortBy { get; set; }
}

public enum PostIssueCommentSortBy
{
    CreationDate = 12,
    CreationDateDescending = 13,
}