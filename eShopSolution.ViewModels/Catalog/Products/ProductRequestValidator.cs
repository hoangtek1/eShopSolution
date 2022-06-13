using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductRequestValidator : AbstractValidator<ProductCreateRequest>
    {
        public ProductRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Vui lòng nhập tên sản phẩm")
                .MaximumLength(200).WithMessage("Tên sản phẩm không được dài hơn 200 kí tự");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Vui lòng nhập giá cho sản phẩm")
                .GreaterThan(0).WithMessage("Giá sản phẩm phải lớn hơn 0");

            RuleFor(x => x.OriginalPrice).NotEmpty().WithMessage("Vui lòng nhập giá ban đầu cho sản phẩm");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Vui lòng nhập số lương tồn kho của sản phẩm");
            RuleFor(x => x.Details).NotEmpty().WithMessage("Vui lòng nhập chi tiết sản phẩm");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Vui lòng nhập mô tả sản phẩm");
            RuleFor(x => x.SeoAlias).NotEmpty().WithMessage("Vui lòng nhập SeoAlias cho sản phẩm");
            RuleFor(x => x.SeoTitle).NotEmpty().WithMessage("Vui lòng nhập SeoTitle cho sản phẩm");
            RuleFor(x => x.SeoDescription).NotEmpty().WithMessage("Vui lòng nhập SeoDescription cho sản phẩm");
            RuleFor(x => x.ThumbnailImage).NotEmpty().WithMessage("Vui lòng nhập thumbnail cho sản phẩm");
        }
    }
}
